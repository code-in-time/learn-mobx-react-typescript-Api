using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication1.Models;

namespace WebApplication1.Views
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {

        // GET: api/Shop
        [HttpGet]
        public string Get()
        {
            Account acc = new Account
            {
                Email = "a",
                Name = "a",
                Phone = "888",
            };

            return JsonConvert.SerializeObject(acc);
        }

        // POST: api/Shop
        [HttpPost]
        public string Post([FromBody] NotesList value)
        {
            //    Account sd = value;
            int s = 1;

            return JsonConvert.SerializeObject(value);
        }
    }
}


//// POST: api/Shop
//[HttpPost]
//public string Post([FromBody] Account value)
//{
//    Account sd = value;
//    int s = 1;

//    return s.ToString();
//}

//// GET: api/Shop
//[HttpGet]
//public IEnumerable<string> Get()
//{
//    return new string[] { "value1", "value2" };
//}

//// GET: api/Shop/5
//[HttpGet("{id}", Name = "Get")]
//public string Get(int id)
//{
//    return "value";
//}



//// PUT: api/Shop/5
//[HttpPut("{id}")]
//public void Put(int id, [FromBody] string value)
//{
//}

//// DELETE: api/ApiWithActions/5
//[HttpDelete("{id}")]
//public void Delete(int id)
//{
//}
