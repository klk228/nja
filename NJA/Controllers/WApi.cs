using NJA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NJA.Controllers
{
    public class WApiController : ApiController
    {
        //private IValueCalculator calc;

      /*  public WApiController(IValueCalculator calcParam)
        {
            calc = calcParam;
        }
        */
        // GET api/wapi
        public IEnumerable<decimal> Get()
        {
            return new decimal[] { 0.1M, 0.2M };
        }

        // GET api/wapi/5
        public decimal Get(string id)
        {
            decimal v = 0;
            switch (id)
            {
                case "QQQ":
                    v = 0.1M;
                    break;
                case "ZZZ":
                    v = 0.2M;
                    break;
                case "WWW":
                    v = 0.4M;
                    break;
                default:
                    v = 0;
                    break;

            }
            return v;
        }

        // POST api/wapi
        public void Post([FromBody]string value)
        {
        }

        // PUT api/wapi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/wapi/5
        
        public void Delete(int id)
        {
        }
    }
}
