using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess.Infrastructure.DataAccess.Model.Portal
{
    public class Pazzle
    {
        public GameState InitialState { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
    }
}
