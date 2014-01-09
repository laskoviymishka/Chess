using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chess.UI.WebApi.Models
{
    public class MoveModel
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Color { get; set; }
    }
}