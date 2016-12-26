using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LocationAPI.Controllers
{
    //[Authorize]
    //[RoutePrefix("api/location")]
    public class ValuesController : ApiController
    {
        /*// GET api/values       
        public IEnumerable<string> Get()
        {

            return new string[] {"values"};
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }*/

        //[Route("send")]
        public string Post(Models.LocationInfo locationInfo)
        {
            if(locationInfo != null)
            {
                return "Success";
            }
            return "Failed";
        }

        //[Route("get")]
        public IEnumerable<string> Get(int id)
        {
            return new string[] { "" + id };
        }

        /*// POST api/values
        public void Post([FromBody]string value)
        {

        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }*/
    }
}
