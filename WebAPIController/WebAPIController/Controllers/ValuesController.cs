using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Collections;
namespace WebAPIController.Controllers
{
    public class ValuesController : ApiController
    {
       static List<string> strings = new List<string> {"str1","str2","str3","str4","str5" };

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return strings;
        }

        // GET api/<controller>/5
        public string Get([FromUri]int id)
        {
            return strings[id];
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
            strings.Add(value);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
            strings[id] = value;
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            strings.RemoveAt(id);
        }
    }
}