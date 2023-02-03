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
        //HTTP GET : Localhost:xxxx/api/HostingCost/Total  -->This is my hosting cost calculation

        [Route("api/hostingcost/{noOfDaysElapsed}")]
        [HttpGet]

        /// <summary>
        /// The function lets us kow the total hoosting cost for the number of days elapsed
        /// </summary>
        /// <param name="noOfDaysElapsed"></param>
        /// <returns>
        /// The value of hosting cost to be charged
        /// no of days elapsed -> 0 to 13 -> 1FN -> Cost = $6.22 CAD
        /// no of days elapsed -> 14 to 27 -> FN -> Cost = $12.43 CAD
        /// no of days elapsed -> 28 to 41 -> FN -> Cost = $18.64 CAD
        /// and so on with multipe of 14
        /// </returns>
        /// 
        ///GET: api/HostingCost/0  --> Response :“1 fortnights at $5.50/FN = $5.50 CAD”
        ///“HST 13% = $0.72 CAD”
        ///“Total = $6.22 CAD”
        ///
        ///GET: api/HostingCost/14  --> Response :“2 fortnights at $5.50/FN = $11.00 CAD”
        ///“HST 13% = $1.43 CAD”
        ///“Total = $12.43 CAD”
        ///
        ///GET: api/HostingCost/28  --> Response :“3 fortnights at $5.50/FN = $16.50 CAD”
        ///“HST 13% = $2.14 CAD”
        ///“Total = $18.64 CAD”
        public string Total(int noOfDaysElapsed)
        {
            // nod be a constant of value 14
            int nod = 14;


            //If noOfDaysElapsed less than 14
            if (noOfDaysElapsed > 0 && noOfDaysElapsed < 1 * nod) //noOfDaysElapsed < 1 * nod
            {
                int noOfFortNight = 1;
                double cost = noOfFortNight * 5.50;
                double hst = cost * 0.13;

                double hostingTotal = cost + hst;

                return noOfFortNight + " fortnights at $5.50/FN = $" + cost + " CAD" + "<br/>" +
                        "HST 13% = $" + hst + " CAD" + "<br/>" +
                        "Total = $" + hostingTotal + " CAD";
            }
            //noOfDaysElapsed less than 28 (i.e 2 * 14) 
            else if (noOfDaysElapsed < 2 * nod)
            {
                int noOfFortNight = 2;
                double cost = noOfFortNight * 5.50;
                double hst = cost * 0.13;

                double hostingTotal = cost + hst;

                return noOfFortNight + " fortnights at $5.50/FN = $" + cost + " CAD" + "<br/>" +
                         "HST 13% = $" + hst + " CAD" + "<br/>" +
                         "Total = $" + hostingTotal + " CAD";
            }
            //noOfDaysElapsed less than 42 (i.e 3 * 14) 
            else if (noOfDaysElapsed < 3 * nod)
            {
                int noOfFortNight = 3;
                double cost = noOfFortNight * 5.50;
                double hst = cost * 0.13;

                double hostingTotal = cost + hst;

                return noOfFortNight + " fortnights at $5.50/FN = $" + cost + " CAD" + "<br/>" +
                        "HST 13% = $" + hst + " CAD" + "<br/>" +
                        "Total = $" + hostingTotal + " CAD";
            }
            else if (noOfDaysElapsed < 4 * nod)
            {
                int noOfFortNight = 4;
                double cost = noOfFortNight * 5.50;
                double hst = cost * 0.13;

                double hostingTotal = cost + hst;

                return noOfFortNight + " fortnights at $5.50/FN = $" + cost + " CAD" + "<br/>" +
                         "HST 13% = $" + hst + " CAD" + "<br/>" +
                         "Total = $" + hostingTotal + " CAD";
            }
            else
            {
                //Used a dummy text. It will be difficult to keeping adding the code with repetitive mutiplies of 14.
                //I could not figure on how to reduce these steps.
                return "The cost is to be calculated";
            }
          

          

        }
       
    }
}
