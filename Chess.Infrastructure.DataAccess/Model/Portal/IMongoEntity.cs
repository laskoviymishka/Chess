using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess.Infrastructure.DataAccess.Model.Portal
{
    public interface IMongoEntity
    {
        string Id { get; set; }
    }
}
