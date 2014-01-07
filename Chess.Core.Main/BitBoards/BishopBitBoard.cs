using System;
using System.Collections.Generic;
using Chess.Core.Main.AttacksGenerators;

namespace Chess.Core.Main.BitBoards
{
	public class BishopBitBoard : BitBoard
	{
		public BishopBitBoard()
			:base()
		{
		}
		
		public BishopBitBoard(ulong val)
			:base(val)
		{					
		}
	}
}

