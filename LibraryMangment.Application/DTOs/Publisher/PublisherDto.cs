using LibraryMangment.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangment.Application.DTOs.Publisher
{
    public class PublisherDto:BaseDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
    }
}
