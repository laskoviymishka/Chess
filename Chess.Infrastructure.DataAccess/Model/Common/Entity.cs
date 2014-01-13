using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Infrastructure.DataAccess.Model.Common
{
    public class Entity
    {
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id
        {
            get;
            set;
        }
    }
}
