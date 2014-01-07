using Chess.Core.Main;
using Chess.Core.Main.ChessBoard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Test.Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            GameProvider game = new GameProvider(new MovesArrayAllocator());
            Console.WriteLine(game.ProcessMove(new Move(Square.E2, Square.E4), Color.White));
            Console.WriteLine(game.ProcessMove(new Move(Square.E7, Square.E5), Color.Black));


            game.ForEachFigure(
                (s, f) =>
                {
                    if (f != Figure.Nobody)
                    {
                        Console.WriteLine(f.ToString() + "----" + s.ToString());
                    }
                });

            Console.ReadLine();
        }
    }
}
