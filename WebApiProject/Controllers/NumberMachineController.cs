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
        /// 
        /// GET localhost/NumberMachine/10 --> 50
        ///GET localhost/NumberMachine/-5 --> -115
        ///GET localhost/NumberMachine/30 --> 35
        public IEnumerable<int> Get(int id)
        {
            //GET api/NumberMachine/{id}
            int result = (id - 10 ) + (100/id) * 5 ;
            return new int[] { result };
        }
    }
}
