using System;

namespace Chess.Infrastructure.DataAccess.Model.Portal
{
    public class Game
    {
        public string Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EmdTime { get; set; }
        public GameState State { get; set; }
        public Chat Chat { get; set; }
    }
}