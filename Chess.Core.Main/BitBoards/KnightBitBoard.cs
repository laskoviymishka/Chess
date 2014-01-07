using System;
using Chess.Core.Main.BitBoards.Helpers;
using System.Collections.Generic;
using Chess.Core.Main.AttacksGenerators;

namespace Chess.Core.Main.BitBoards
{
	public class KnightBitBoard : BitBoard
	{
		public KnightBitBoard()
			:base()
		{
		}
		
		public KnightBitBoard(ulong val)
			:base(val)
		{
		}
	}
}

