using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Application.Dtos
{
    public class ImageDto
    {
        public string? Url { get; set; }
        public string? ImageBase64 { get; set; }
    }
}
