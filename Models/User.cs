using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace  Focal.Models
{
    public class User
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get ; set; }

        [BsonElement("Email")]
         public string Email { get ; set ; }


        [BsonElement("password")]
        public string Password { get; set; }
         
 
    }
}