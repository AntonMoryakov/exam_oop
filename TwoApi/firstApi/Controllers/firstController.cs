using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace firstApi.Controllers{
    [Route("home")]
    [ApiController]
    public class HomeController : Controller{
        [HttpGet("GetMethod")]
        public ActionResult GetMethod(){
            var student = new List<Student>{
                new Student{Id = 1, Name = "name1", Description = "discr1"},
                new Student{Id = 2, Name = "name2", Description = "discr2"},
                new Student{Id = 3, Name = "name3", Description = "discr3"},
                new Student{ Id = 4, Name = "name4", Description = "diskr4"}
            };
            return Json(student);
        }
        
    }
    public class Student{
        public int Id{ get; set; }
        public string Name { get; set;}
        public string Description { get; set;}
    }
}