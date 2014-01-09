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
        private GameProvider _game;
        private ChessSolver _solver;

        [HttpGet]
        public void Start()
        {
            _game = new GameProvider(new MovesArrayAllocator());
            _solver = new ChessSolver(new DebutGraph());
        }

        [HttpGet]
        public void Move([FromUri]MoveModel model)
        {
            if (_game == null)
            {
                Start();
            }

            Square from = (Square)Enum.Parse(typeof(Square), model.From, true);
            Square to = (Square)Enum.Parse(typeof(Square), model.To, true);
            Color color = Color.White;
            if (model.Color == "b")
            {
                color = Color.Black;
            }

            _game.ProcessMove(new Move(from, to), color);
            var solverMove = _solver.SolveProblem(_game, Color.Black, 4);
            _game.ProcessMove(solverMove, Color.Black);
            BroadcasterContext.Current.UpdateMove(new MoveModel
            {
                Color = "b",
                From = solverMove.From.ToString().ToLower(),
                To = solverMove.To.ToString().ToLower()
            });
        }
    }
}
