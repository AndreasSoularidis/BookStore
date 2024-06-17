using System.Reflection;

namespace BookStoreAPI.DTOs
{
    public class BookDTO
    {
        public Guid Id { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        public int Pages { get; set; }
        public string Publisher { get; set; }
    }
}
