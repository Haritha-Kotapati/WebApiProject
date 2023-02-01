using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiProject.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// This number returns the square value of id
        /// </summary>
        /// <param name="id"></param>
        /// returns the power of 2 to the id value
        /// <returns>[Math.Pow(id, 2)]</returns>
        public IEnumerable<int> Get(int id)
        {
            double ans = Math.Pow(id, 2);
            //  return new int[] { id * id };
            return new int[] { (int)ans };
        }
    }
}
