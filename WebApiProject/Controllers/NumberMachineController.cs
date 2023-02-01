using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiProject.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// This method returns the four operators performed upon the id value when receiving a Get request
        /// </summary>
        /// <example> Get api/NumberMachine/{id} </example>
        /// <param name="id"></param>
        /// <returns> [ (id - 10 ) + (100/id) * 5 ] </returns>
        public IEnumerable<int> Get(int id)
        {
            //GET 
            int result = (id - 10 ) + (100/id) * 5 ;
            return new int[] { result };
        }
    }
}
