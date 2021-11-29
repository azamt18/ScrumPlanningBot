using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace ScrumPlanningBot.Core.Entities
{
    public class Story : BaseEntity
    {
        [BsonElement("title")]
        public string Title { get; set; }

        [BsonElement("creatorUserId")]
        public long CreatorUserId { get; set; }

        [BsonElement("users")]
        public List<StoryUser> Users { get; set; }

        [BsonElement("isClosed")]
        public bool IsClosed { get; set; }

        [BsonElement("closedAt")]
        [DataType(DataType.DateTime)]
        public DateTime? ClosedAt { get; set; }
        
        [BsonElement("averageStoryPoint")]
        public double AverageStoryPoint { get; set; }
        
        [BsonElement("averageHour")] 
        public double AverageHour { get; set; }
    }

    public class StoryUser
    {
        [BsonElement("userId")]
        public long UserId { get; set; }

        [BsonElement("storyPoint")]
        public double StoryPoint { get; set; }

        [BsonElement("hour")]
        public double Hour { get; set; }
    }
}