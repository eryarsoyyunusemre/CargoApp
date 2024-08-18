using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CargoApp.Entities.Models
{
    public class Shipping : BaseEntity
    {
        
        // Gönderici üyenin ID'si
        [BsonRepresentation(BsonType.ObjectId)]
        public string SenderId { get; set; }
        
        // Alıcı üyenin ID'si
        [BsonRepresentation(BsonType.ObjectId)]
        public string ReceiverId { get; set; }

        public int PackageNumber { get; set; }
        public int PackageWeight { get; set; }
        public string Description { get; set; }
    }
}