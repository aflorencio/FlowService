using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlowService.Core.DB.Models
{
    public class Status
    {
        [BsonIgnoreIfNull]
        public bool tomaContacto { get; set; }
        [BsonIgnoreIfNull]
        public bool rastreo { get; set; }
        [BsonIgnoreIfNull]
        public bool presupuesto { get; set; }
        [BsonIgnoreIfNull]
        public bool docEnviada { get; set; }
        [BsonIgnoreIfNull]
        public bool firmado { get; set; }
        [BsonIgnoreIfNull]
        public bool desechado { get; set; }
    }

    public class Timeline
    {
        [BsonIgnoreIfNull]
        public string tipo { get; set; }
        [BsonIgnoreIfNull]
        public ObjectId idTipo { get; set; }
        [BsonIgnoreIfNull]
        public string fecha { get; set; }
        [BsonIgnoreIfNull]
        public string titulo { get; set; }
        [BsonIgnoreIfNull]
        public string mensaje { get; set; }
        [BsonIgnoreIfNull]
        public string ticket { get; set; }
        [BsonIgnoreIfNull]
        public bool visto { get; set; }
        [BsonIgnoreIfNull]
        public bool terminado { get; set; }
    }
    [BsonIgnoreExtraElements]
    public class FlowDBModel
    {
        public ObjectId _id { get; set; }
        [BsonIgnoreIfNull]
        public ObjectId contactoID { get; set; }
        [BsonIgnoreIfNull]
        public Status status { get; set; }
        [BsonIgnoreIfNull]
        public List<Timeline> timeline { get; set; }
    }
}