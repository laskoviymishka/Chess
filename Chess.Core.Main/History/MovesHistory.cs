using System;
using Chess.Core.Main;
using System.Linq;
using System.Collections.Generic;

namespace Chess.Core.Main.History
{
	public class MovesHistory
	{
		protected readonly int maxlength = 10000;
		protected List<Move> moves;
		protected List<DeltaChange> deltaChanges;
		protected int lastIndex;
	
		public MovesHistory ()
		{
			this.moves = new List<Move>(maxlength);
			this.deltaChanges = new List<DeltaChange>(maxlength);			
			this.lastIndex = -1;
			this.FillCache();
		}

        public void Reset()
        {
            this.lastIndex = -1;
        }

        public List<Move> Moves
        {
            get { return this.moves.Take(this.lastIndex + 1).ToList(); }
        }
		
		protected void FillCache()
		{
			int N = this.maxlength;
			
			while ((--N) > 0)
			{
				moves.Add(new Move(Square.A1, Square.A1));
				deltaChanges.Add(new DeltaChange());
			}
		}

        public string[] GetMovesArray()
        {
            return this.moves.Take(this.lastIndex + 1)
                .Select((move) => move.ToString()).ToArray();
        }
		
		public DeltaChange PopLastDeltaChange()
		{
			return this.deltaChanges[lastIndex--];
		}
		
		public DeltaChange GetLastDeltaChange()
		{
			return this.deltaChanges[lastIndex];
		}
		
		public DeltaChange GetNextDeltaChange()
		{
			lastIndex++;
			return this.deltaChanges[lastIndex];
		}
		
		public Move GetLastMove()
		{
			return this.moves[lastIndex];
		}

        public Move GetPreLastMove()
        {
            return this.moves[lastIndex - 1];
        }
		
		public Move GetNextMove()
		{
			lastIndex++;
			return this.moves[lastIndex];
		}
		
		public void AddItem(Move move)
		{
			lastIndex++;
			
			this.moves[lastIndex].From = move.From;
			this.moves[lastIndex].To = move.To;
			this.moves[lastIndex].Type = move.Type;
		}
		
		public void RemoveLastItem()
		{
#if DEBUG
			if (lastIndex == 0)
				throw new InvalidOperationException();
#endif
			lastIndex--;
            
		}

        public bool HasItems()
        {
            return this.lastIndex >= 0;
        }

        public void ClearAll()
        {
            this.lastIndex = 0;
        }
	}
}

