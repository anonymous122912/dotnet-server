using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class User
{
  [BsonId]
  [BsonRepresentation(BsonType.ObjectId)]

  public string? Id { get; set; }

  [BsonElement("fullname")]
  public string Fullname { get; set; } = null!;

  [BsonElement("email")]
  public string Email { get; set; }= null!;

  [BsonElement("password")]
  public string Password { get; set; }= null!;

  [BsonElement("createdAt")]
  public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

  [BsonElement("updatedAt")]
  public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}




