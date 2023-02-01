using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiProject.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// This method returns value added with ten when receiving get request
        /// <addten> GET api/addten/{id} </addten>
        /// </summary>
        /// <returns> [id + 10] </returns>

        // GET api/addTen/{id}
        public IEnumerable<int> Get(int id)
        {
            return new int[] { id + 10 };
        }

     
    }
}