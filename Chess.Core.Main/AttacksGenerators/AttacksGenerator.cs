using System;

namespace Chess.Core.Main.AttacksGenerators
{
	public abstract class AttacksGenerator
	{
		public abstract ulong GetAttacks(Square figures, ulong otherFigures);
	}
}

