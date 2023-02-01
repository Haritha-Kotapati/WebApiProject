using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiProject.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// This method returns the string value when receiving a Post request
        /// </summary>
        /// <example> POST api/greeting </example>
        /// <returns>[ "Hello World!" ]</returns>
        public IEnumerable<string> Post()
        {
            return new string[] { "Hello World!" };
        }

        /// <summary>
        /// This method returns the string value when receiving a Get request
        /// </summary>
        /// <example>GET api/greeting/{id} </example>
        /// <returns>[ "Hello World!" ]</returns>
        // 
        public IEnumerable<string> Get(int id)
        {
            return new string[] { "Greetings to " + id + " people!" };
        }
    }
}
