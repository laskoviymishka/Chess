using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess.Infrastructure.DataAccess.Model.Portal
{
    public class ChatMessage : IMongoEntity
    {
        public string Id { get; set; }
        public string Body { get; set; }
        public string AuthorId { get; set; }
        public DateTime SendTime { get; set; }
        public string ChatID { get; set; }
    }
}
