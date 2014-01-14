using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Infrastructure.DataAccess.Model.Portal
{
    public class Rating
    {
        public UserAccount User { get; set; }
        public int Place { get; set; }
        public int PreviosPlace { get; set; }
    }
}
