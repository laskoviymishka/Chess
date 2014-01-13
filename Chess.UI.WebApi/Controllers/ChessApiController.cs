using Chess.Core.Main;
using Chess.Core.Main.ChessBoard;
using Chess.UI.WebApi.Hubs;
using Chess.UI.WebApi.Models;
using DebutsLib;
using Queem.AI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Chess.UI.WebApi.Controllers
{
    public class ChessApiController : ApiController
    {
        [HttpGet]
        public void Start()
        {
            InMemory.Game = new Dictionary<string, GameProvider>();
            InMemory.Solver = new Dictionary<string, ChessSolver>();
            InMemory.Game.Add("test", new GameProvider(new MovesArrayAllocator()));
            InMemory.Solver.Add("test", new ChessSolver(new DebutGraph()));

        }

        [HttpGet]
        public void Move([FromUri]MoveModel model)
        {
            Square from = (Square)Enum.Parse(typeof(Square), model.From, true);
            Square to = (Square)Enum.Parse(typeof(Square), model.To, true);
            Color color = Color.White;
            if (model.Color == "b")
            {
                color = Color.Black;
            }

            InMemory.Game["test"].ProcessMove(new Move(from, to), color);
            var solverMove = InMemory.Solver["test"].SolveProblem(InMemory.Game["test"], Color.Black, 4);
            InMemory.Game["test"].ProcessMove(solverMove, Color.Black);
            BroadcasterContext.Current.UpdateMove(new MoveModel
            {
                Color = "b",
                From = solverMove.From.ToString().ToLower(),
                To = solverMove.To.ToString().ToLower()
            });
        }
    }

    public class InMemory
    {
        public static Dictionary<string, GameProvider> Game;
        public static Dictionary<string, ChessSolver> Solver;

    }
}
