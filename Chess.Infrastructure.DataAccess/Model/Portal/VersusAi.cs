using Chess.Core.Main;

namespace Chess.Infrastructure.DataAccess.Model.Portal
{
    public class VersusAi : Game
    {
        public int AiLevel { get; set; }
        public Color PlayerColor { get; set; }
    }
}