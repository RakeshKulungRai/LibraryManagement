using LibraryManagment.Domain.Common;

namespace LibraryManagment.Domain
{
    public class Book:BaseDomainEntity
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
        public string Edition { get; set; }
        public byte[]? Image { get; set; }
        public string? PublishedYear { get; set; }
        public Publisher Publisher { get; set; }
        public ICollection<Author> Authors { get; set; }

    }
}
