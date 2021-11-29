using MongoDB.Bson.Serialization.Attributes;

namespace ScrumPlanningBot.Core.Entities
{
    public class User : BaseEntity
    {
        [BsonElement("telegramId")]
        public long? TelegramId { get; set; }

        [BsonElement("phone")]
        public string Phone { get; set; }

        [BsonElement("username")]
        public string Username { get; set; }

        [BsonElement("fullaname")]
        public string Fullname { get; set; }
    }
}