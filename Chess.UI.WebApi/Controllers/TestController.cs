﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Chess.UI.WebApi.Controllers
{
    public class TestController : ApiController
    {
        public List<string> Get()
        {
            return new List<string> { "a", "b"};
        }
    }
}
