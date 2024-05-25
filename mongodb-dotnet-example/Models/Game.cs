using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace mongodb_dotnet_example.Models
{
    public class Game
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string id { get; set; }
        public string name { get; set; }

        public decimal price { get; set; }

        public string category { get; set; }

    }
}