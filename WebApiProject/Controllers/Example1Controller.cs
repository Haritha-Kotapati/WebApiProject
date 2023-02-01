using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiProject.Controllers
{
    public class Example1Controller : ApiController
    {
        // POST api/example1
        public IEnumerable<string> Post()
        {
            return new string[] { "ex1", "ex2", "ex10" };
        }

        // GET api/example1/{id}
        public IEnumerable<string> Get(int id)
        {
            return new string[] { "ex1ex", "ex2ex", "ex10ex" };
        }
    }
}
