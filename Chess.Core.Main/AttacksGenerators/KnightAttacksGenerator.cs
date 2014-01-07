using System;
using System.Collections.Generic;
using Chess.Core.Main.BitBoards.Helpers;

namespace Chess.Core.Main.AttacksGenerators
{
	public class KnightAttacksGenerator : AttacksGenerator
	{
		public override ulong GetAttacks (Square figureSquare, ulong otherFigures)
		{
			return KnightBitBoardHelper.KnightMoves[(int)figureSquare];
		}
	}
}

