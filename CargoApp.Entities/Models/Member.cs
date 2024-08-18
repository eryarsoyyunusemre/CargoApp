using System.Runtime.CompilerServices;
using CargoApp.Entities.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CargoApp.Entities.Models
{
    public class Member :BaseEntity
    {
        
        public string Name { get; set; }
        
        public string LastName { get; set; }
        
        public string Address { get; set; }
        
        public AddressEnum AddressType { get; set; } // Enum olarak saklanacak
        
        // Bir üyenin gönderdiği kargoların ID'leri
        public List<string> SentShippingIds { get; set; }
        
        // Bir üyenin aldığı kargoların ID'leri
        public List<string> ReceivedShippingIds { get; set; }
    }


}