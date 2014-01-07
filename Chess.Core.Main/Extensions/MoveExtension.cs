using System;
using Chess.Core.Main;
using Chess.Core.Main.BitBoards.Helpers;

namespace Chess.Core.Main.Extensions
{
    public static class MoveExtension
    {
        public static int GetDeltaX(this Move move)
        {
            int fileStart = (int)BitBoardHelper.GetFileFromSquare(move.From);
            int fileEnd = (int)BitBoardHelper.GetFileFromSquare(move.To);

            return fileEnd - fileStart;
        }

        public static int GetDeltaY(this Move move)
        {
            int rankStart = BitBoardHelper.GetRankFromSquare(move.From);
            int rankEnd = BitBoardHelper.GetRankFromSquare(move.To);

            return rankEnd - rankStart;
        }
    }
}
