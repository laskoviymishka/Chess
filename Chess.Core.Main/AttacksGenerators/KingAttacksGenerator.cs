using System;
using Chess.Core.Main.BitBoards.Helpers;

namespace Chess.Core.Main.AttacksGenerators
{
	public class KingAttacksGenerator : AttacksGenerator
	{
		public override ulong GetAttacks (Square figureSquare, ulong otherFigures)
		{
			return KingBitBoardHelper.KingMoves[(int)figureSquare];
		}
	}
}

