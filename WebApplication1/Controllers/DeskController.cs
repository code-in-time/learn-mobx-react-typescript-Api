using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class DeskController : Controller
    {

        public IActionResult Index()
        {
            var s = Json(new { foo = "bar", baz = "Blech" });

            return s;
            //return View();
        }
        // GET: /<controller>/
        public IActionResult Load(int id = 6, string name = null, string email = null)
        {
            // Convert params from url into person object
            Person P = new Person()
            {
                Name = name,
                Email = email,
                Id = id,
            };

            //Person p = new Person ()
            //p.Id = id,
            //p.

            // var json = new JavaScriptSerializer().Serialize(P);

            //var s = Json(new { foo = "bar", baz = "Blech" });
            var s = Json(P);

            return s;
            //return View();
        }

        //[HttpPost]
        //public IActionResult Add([FromBody] Smurf s)
        //{

        //    Smurf t = s;
        //    int h = 1;
        //    return Json(s);
        //}
    }
}
