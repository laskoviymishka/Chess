using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chess.Core.Main;

namespace Chess.Infrastructure.DataAccess.Model.Portal
{
    public class ChessFigure
    {
        public Figure Figure { get; set; }
        public Color Color { get; set; }
        public Square Square { get; set; }
    }
}
