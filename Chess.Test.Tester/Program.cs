using Chess.Core.Main;
using Chess.Core.Main.ChessBoard;
using DebutsLib;
using Queem.AI;
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
            ChessSolver solver = new ChessSolver(new DebutGraph());

            Move solverMove;
            bool gameEnd = false;
            while (!gameEnd)
            {
                if (game.IsCheckmate(Color.White))
                {
                    gameEnd = true;
                    break;
                }

                solverMove = solver.SolveProblem(game, Color.White, 1);
                game.ProcessMove(solverMove, Color.White);
                Console.WriteLine(solverMove.ToString() + "---- WHITE");

                if (game.IsCheckmate(Color.Black))
                {
                    gameEnd = true;
                    break;
                }

                solverMove = solver.SolveProblem(game, Color.Black, 4);
                game.ProcessMove(solverMove, Color.Black);
                Console.WriteLine(solverMove.ToString() + "---- BLACK");
            }

            game.ForEachFigureReal((s, f, c) =>
            {
                Console.WriteLine(s.ToString() + "" + f.ToString() + "" + c.ToString());
            });

            Console.ReadLine();
        }
    }
}
