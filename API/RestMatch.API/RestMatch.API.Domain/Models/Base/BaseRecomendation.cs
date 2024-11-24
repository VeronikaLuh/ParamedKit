using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Domain.Models.Base
{
    public abstract class BaseRecomendation
    {
        [Key]
        public int Id { get; set; }
        public double Italian { get; set; }
        public int CountOfRateItalian { get; set; }
        public double Chinese { get; set; }
        public int CountOfRateChinese { get; set; }
        public double Mexican { get; set; }
        public int CountOfRateMexican { get; set; }
        public double Japanese { get; set; }
        public int CountOfRateJapanese { get; set; }
        public double Indian { get; set; }
        public int CountOfRateIndian { get; set; }
        public double French { get; set; }
        public int CountOfRateFrench { get; set; }
        public double Mediterranean { get; set; }
        public int CountOfRateMediterranean { get; set; }
        public double American { get; set; }
        public int CountOfRateAmerican { get; set; }
        public double Greek { get; set; }
        public int CountOfRateGreek { get; set; }
        public double Ukrainian { get; set; }
        public int CountOfRateUkrainian { get; set; }
    }
}
