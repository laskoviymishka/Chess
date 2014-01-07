using System;
using System.Linq;
using System.Diagnostics;
using Chess.Core.Main.BitBoards;

namespace Chess.Core.Main.BitBoards.Helpers
{
    public static class RookBitBoardHelper
    {
        public static readonly byte[,] FirstRankAttacks;
        public static readonly ulong[] RotatedBytes;

        public static readonly ulong LeftRookMask;
        public static readonly ulong RightRookMask;

        static RookBitBoardHelper()
        {
            FirstRankAttacks = GenerateFirstRankAttacks();
            RotatedBytes = GenerateRotatedRanks();

            LeftRookMask = GetLeftRookMask();
            RightRookMask = GetRightRookMask();
        }

        public static byte[,] GenerateFirstRankAttacks()
        {
            byte[,] situations = new byte[8, 256];

            for (int i = 0; i < 8; ++i)
            {
                int rookPos = 0x1 << i;
                int otherFiguresMask = ~rookPos;

                byte[] arr = Enumerable.
                    Range(0, 256).
                    // remove bit with current rook position
                    Select(n => (byte)(n & otherFiguresMask)).
                    Distinct().
                    ToArray();

                Debug.Assert(arr.Length == 128, "Wrong count");

                Array.ForEach(arr,
                              (otherFigures) =>
                              situations[7 - i, otherFigures] =
                                GetByteRankMovesMask((byte)rookPos, otherFigures));
            }
            return situations;
        }

        public static byte GetByteRankMovesMask(byte rookPosition, byte otherFigures)
        {
            /*
             * Test input 
             *  rook position - 00001000
             *  other figures - 01000010
             * Output           01110110
            */

            byte moves = 0;

            byte left = (byte)(rookPosition << 1);
            while (left != 0)
            {
                moves |= left;
                // set bit means other figure there
                if ((left & otherFigures) == left)
                    break;
                left = (byte)(left << 1);
            }

            byte right = (byte)(rookPosition >> 1);
            while (right != 0)
            {
                moves |= right;
                // set bit means other figure there
                if ((right & otherFigures) == right)
                    break;
                right = (byte)(right >> 1);
            }

            return moves;
        }

        public static ulong[] GenerateRotatedRanks()
        {
            return Enumerable.Range(0, 256)
                        .Select(b => BitBoardHelper.FlipDiagonalA1H8((ulong)b))
                        .ToArray();
        }

        private static ulong GetLeftRookMask()
        {
            var bb = new BitBoard();
            bb.SetBit(Square.A1);
            bb.SetBit(Square.A8);
            return bb.GetInnerValue();
        }

        private static ulong GetRightRookMask()
        {
            var bb = new BitBoard();
            bb.SetBit(Square.H1);
            bb.SetBit(Square.H8);
            return bb.GetInnerValue();
        }
    }
}

