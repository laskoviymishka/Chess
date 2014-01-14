using System.Collections.Generic;
using Chess.Core.Main;

namespace Chess.Infrastructure.DataAccess.Model.Portal
{
    public class GameState
    {
        public List<Move> MoveHistory { get; set; }
        public List<ChessFigure> Figures { get; set; }
        public List<Move> AvaibleMoves { get; set; }
        public Color TurnColor { get; set; }
    }
}