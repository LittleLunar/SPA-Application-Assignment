using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Text.Json.Serialization;

namespace spa_backend.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = ObjectId.GenerateNewId().ToString();

        [BsonElement("username")]
        [JsonPropertyName("username")]
        public string Username { get; set; } = null!;

        [BsonElement("password")]
        [JsonPropertyName("password")]
        public string Password { get; set; } = null!;

        [BsonElement("role")]
        [JsonPropertyName("role")]
        public string Role { get; set; } = null!;

        [BsonElement("created_date")]
        [JsonPropertyName("created_date")]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [BsonElement("updated_date")]
        [JsonPropertyName("updated_date")]
        public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;
    }
}
