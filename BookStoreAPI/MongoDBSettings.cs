namespace BookStoreAPI
{
    public class MongoDBSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string BookCollectionName { get; set; }
        public string UserCollectionName {  get; set; }
    }
}
