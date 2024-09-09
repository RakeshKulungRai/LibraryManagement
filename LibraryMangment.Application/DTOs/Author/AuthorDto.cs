using LibraryMangment.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangment.Application.DTOs.Author
{
    public class AuthorDto:BaseDto
    {
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }
        public string? BioGraphy { get; set; }
        public byte[]? Image { get; set; }

    }
}
