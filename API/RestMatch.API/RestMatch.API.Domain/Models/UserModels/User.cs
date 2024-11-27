using RestMatch.API.Domain.Models.Base;
using RestMatch.API.Domain.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Domain.Models.UserModels
{
    public class User : BaseEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string? ImageUrl { get; set; }

        public IEnumerable<Role> Role { get; set; }
        public IEnumerable<Favourite> Favourites { get; set; }
        public IEnumerable<UserSelectedCriteria> SelectedCriterias { get; set; }
    }
}
