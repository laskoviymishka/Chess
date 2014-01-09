using Chess.UI.WebApi.Models;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chess.UI.WebApi.Hubs
{
    public class ChessHub : Hub
    {
        // Code not shown puts a singleton instance of Broadcaster in this variable.
        private Broadcaster _broadcaster = BroadcasterContext.Current;

        public void SolverMoved(MoveModel clientModel)
        {
            _broadcaster.UpdateMove(clientModel);
        }
    }


    public class Broadcaster
    {
        bool _modelUpdated = false;
        MoveModel _model;
        IHubContext _hubContext;

        public Broadcaster()
        {
            _hubContext = GlobalHost.ConnectionManager.GetHubContext<ChessHub>();
        }

        public void UpdateMove(MoveModel model)
        {
            _model = model;
            _modelUpdated = true;
            _hubContext.Clients.All.solverMoved(_model);
        }

        // Called by a Timer object.
        public void BroadcastModel(object state)
        {
            if (_modelUpdated)
            {
                _hubContext.Clients.All.solverMoved(_model);
                _modelUpdated = false;
            }
        }
    }

    public class BroadcasterContext
    {
        private static Broadcaster _broadcaster;

        public static Broadcaster Current
        {
            get
            {
                if (_broadcaster == null)
                {
                    _broadcaster = new Broadcaster();
                }
                return _broadcaster;
            }
        }
    }
}