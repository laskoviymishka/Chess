using System;
using System.Collections.Generic;
using Chess.Core.Main.AttacksGenerators;

namespace Chess.Core.Main.BitBoards
{	
	public class QueenBitBoard : BitBoard
	{
		public QueenBitBoard()
			:base()
		{
		}
		
		public QueenBitBoard (ulong val)
			:base(val)
		{
		}
	}
}

