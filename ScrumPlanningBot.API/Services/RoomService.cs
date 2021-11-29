using System.Collections.Generic;
using MongoDB.Driver;
using ScrumPlanningBot.Core.Entities;

namespace ScrumPlanningBot.Core.Services
{
    public class RoomService
    {
        private readonly IMongoCollection<Room> _rooms;

        public RoomService(IMongoDbSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _rooms = database.GetCollection<Room>(settings.RoomsCollectionName);
        }

        public List<Room> Get() =>
            _rooms.Find(book => true).ToList();

        public Room Get(string id) =>
            _rooms.Find<Room>(user => user.Id == id).FirstOrDefault();

        public Room Create(Room book)
        {
            _rooms.InsertOne(book);
            return book;
        }

        public void Update(string id, Room bookIn) =>
            _rooms.ReplaceOne(book => book.Id == id, bookIn);

        public void Remove(Room bookIn) =>
            _rooms.DeleteOne(book => book.Id == bookIn.Id);

        public void Remove(string id) =>
            _rooms.DeleteOne(book => book.Id == id);
    }
}