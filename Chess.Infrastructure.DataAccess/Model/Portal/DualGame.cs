using Chess.Core.Main;

namespace Chess.Infrastructure.DataAccess.Model.Portal
{
    public class DualGame : Game
    {
        public Color Player1Color { get; set; }
        public Color Player2Color { get; set; }
        public UserAccount Player1 { get; set; }
        public UserAccount Player2 { get; set; }
    }
}