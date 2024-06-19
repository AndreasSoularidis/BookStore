using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BookStoreAPI.Entities
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime PublishDate { get; set; }
        public int Pages { get; set; }
        public string Publisher { get; set; }
    }
}
