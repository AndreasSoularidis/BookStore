using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BookStoreAPI.Entities
{
    public class BasketItem
    {
        public string BookId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
