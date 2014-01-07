using System;
using Chess.Core.Main.Extensions;
using System.Linq;
using System.Diagnostics;
using Chess.Core.Main.BitBoards;
using Chess.Core.Main;
using Chess.Core.Main.BitBoards.Helpers;

namespace MovesGenerators
{
	public class RookMovesGenerator : Generator
	{
		public override void Run ()
		{
			this.data = RookBitBoardHelper.GenerateRotatedRanks();
		}
		
		public override void WriteResults (System.IO.TextWriter tw)
		{
			tw.WriteLine (string.Join("\n\n", 
			                               ((ulong[])this.data).Select(u => this.GetBoardString(u)).ToArray()));
		}
	}
}

