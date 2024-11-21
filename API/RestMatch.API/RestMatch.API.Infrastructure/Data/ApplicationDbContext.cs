using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RestMatch.API.Domain.Enums;
using RestMatch.API.Domain.Models;
using RestMatch.API.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RestMatch.API.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //Database.Migrate();
        }

        public DbSet<CuisineType> Cuisines { get; set; } = null!;
        public DbSet<Restaurant> Restaurants { get; set; } = null!;
        public DbSet<RestaurantCuisine> RestaurantCuisines { get; set; } = null!;
        public DbSet<RestaurantImageUrl> RestaurantImageUrls { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CuisineType>().HasData(
                Enum.GetValues(typeof(Cuisine))
                    .Cast<Cuisine>()
                    .Select(i => new CuisineType
                    {
                        Id = (int)i,
                        Name = i.ToString(),
                    })
            );
            SeedExtensions.Initialize(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                HandleValidationErrors();
                HandleAuditChangeSet();
                return base.SaveChangesAsync(cancellationToken);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception("Concurrency Exception Occurred.");
            }
            catch (DbUpdateException ex)
            {
                var errorMessageBuilder = new StringBuilder();

                foreach (var entry in ex.Entries)
                {
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            entry.State = EntityState.Detached;
                            break;
                        case EntityState.Modified:
                            entry.CurrentValues.SetValues(entry.OriginalValues);
                            entry.State = EntityState.Unchanged;
                            break;
                    }

                    errorMessageBuilder.AppendLine($"Entity: '{entry.Entity}'");
                }

                Exception exceptionNode = ex;

                while (exceptionNode.InnerException != null)
                {
                    exceptionNode = exceptionNode.InnerException;
                }

                errorMessageBuilder.Append(exceptionNode.Message);

                throw new Exception(errorMessageBuilder.ToString());
            }
        }

        private void HandleValidationErrors()
        {
            var errorMessageBuilder = new StringBuilder();

            IEnumerable<EntityEntry> entries = ChangeTracker
                .Entries()
                .Where(e => (e.State == EntityState.Added) || (e.State == EntityState.Modified));

            foreach (var entry in entries)
            {
                var entity = entry.Entity;
                var context = new ValidationContext(entity);
                var results = new List<ValidationResult>();

                if (!Validator.TryValidateObject(entity, context, results, true))
                {
                    IEnumerable<ValidationResult> failedValidationResults = results.Where(r => r != ValidationResult.Success);

                    foreach (var result in failedValidationResults)
                    {

                        errorMessageBuilder.AppendLine("Validation errors found:");

                        foreach (var field in result.MemberNames)
                        {
                            errorMessageBuilder.AppendLine($"Property: '{field}'; Error: '{result.ErrorMessage}'");
                        }
                    }
                }
            }

            if (errorMessageBuilder.Length > 0)
            {
                throw new ValidationException(errorMessageBuilder.ToString());
            }
        }

        private void HandleAuditChangeSet()
        {
            var changeSet = ChangeTracker.Entries<IBaseEntity>();
            var currentDateTime = DateTime.UtcNow;

            if (changeSet != null)
            {
                var entries = changeSet
                    .Where(e => (e.State == EntityState.Added) || (e.State == EntityState.Modified));

                foreach (var entry in entries)
                {
                    if (entry.State == EntityState.Added)
                    {
                        entry.Entity.CreatedAt = currentDateTime;
                    }

                    entry.Entity.ModifiedAt = currentDateTime;
                }
            }
        }
    }
}
