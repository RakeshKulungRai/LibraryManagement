using LibraryMangment.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangment.Application.DTOs.Book
{
    public class BookDto:BaseDto
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
        public string Edition { get; set; }
        public byte[]? Image { get; set; }
        public string? PublishedYear { get; set; }
        public int PublisherId { get; set; }
    }
}
