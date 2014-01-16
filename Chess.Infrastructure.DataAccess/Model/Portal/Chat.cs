using Chess.Infrastructure.DataAccess.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Chess.Infrastructure.DataAccess.Model.Portal
{
    public class Chat
    {
        private Chat()
        {
        }

        public string Id { get; set; }
        public List<ChatMessage> Messages { get; private set; }

        public static Chat ChatFactory(string chatId)
        {
            var chat = new Chat();
            chat.Id = chatId;
            chat.Messages = MongoRepository<ChatMessage>.RepositoryFactory("mongodb://tserakhau.cloudapp.net", "Chess").GetAll().OrderBy(t => t.SendTime).ToList();
            return chat;
        }
    }
}