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
            List<Note> ln = new List<Note>();
            ln.Add(new Note
            {
                date = DateTime.Now.ToString("h:mm tt"),
                ID = "7",
                msg = "this sis a message"
            });
            ln.Add(new Note
            {
                date = DateTime.Now.ToString("h:mm tt"),
                ID = "2",
                msg = "this sis a message again"
            });

            NotesList n = new NotesList();
            n.NotesL = ln;
            

            return JsonConvert.SerializeObject(n);
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
