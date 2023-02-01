using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiProject.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2", "value10" };
        }

        // GET api/values/5
        public IEnumerable<int> Get(int id)
        {
          //  return new int[] {id+5,id+6,id+100,id+20};
            return new int[] { id ^ 2, id - 2 };
        }

        // GET api/AddTen/10
        public IEnumerable<int> AddTen(int x)
        {
            return new int[] { x+10 };
        }


        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
