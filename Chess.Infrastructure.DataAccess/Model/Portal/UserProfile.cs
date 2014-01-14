using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess.Infrastructure.DataAccess.Model.Portal
{
    public class UserProfile
    {
        public List<Game> GameHistory { get; set; }
        public List<Game> AvaibleGames { get; set; }
        public List<Badge> Badges { get; set; }
        public Rating Rating { get; set; }
    }
}
