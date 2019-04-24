using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace FlowService.Core.DB.Query
{
    public class FlowQuery
    {
        private IMongoClient _client;
        private IMongoDatabase _database;
        private IMongoCollection<FlowService.Core.DB.Models.FlowDBModel> _flowCollection;

        public FlowQuery(string connectionString) //COSNTRUCTOR 
        {
            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase("FlowService");
            _flowCollection = _database.GetCollection<FlowService.Core.DB.Models.FlowDBModel>("flow");
        }


        public void createNewFlow(string id) {
            FlowService.Core.DB.Models.FlowDBModel data = new Models.FlowDBModel();
            data.contactoID = ObjectId.Parse(id);
            _flowCollection.InsertOneAsync(data);
        }

        public void addToFlow(string id, FlowService.Core.DB.Models.Timeline dataTimeline) {

            var filter = Builders<Core.DB.Models.FlowDBModel>.Filter.Eq(e => e.contactoID, ObjectId.Parse(id));
            var update = Builders<Core.DB.Models.FlowDBModel>.Update.Push<Core.DB.Models.Timeline>(e => e.timeline, dataTimeline);

           _flowCollection.FindOneAndUpdateAsync(filter, update);
        }

        public void deleteToFlow() {

        }
    }
}