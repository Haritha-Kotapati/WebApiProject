using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiProject.Controllers
{
    public class HostingCostController : ApiController
    {
        public IEnumerable<string> Get(int id)
        {
            id = id / 14;
            
            
            int cost = id  * 2;
            return new string[] { id + " fortnights at $5.50/FN= $" };
        }
    }
}
