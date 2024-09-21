using Microsoft.AspNetCore.Mvc;

namespace MyWebApi.Controllers{
    [Route("home")]
    [ApiController]
    public class HomeController : ControllerBase{
        private static readonly List<Student> Students = new List<Student>();
        public HomeController(){}
        [HttpGet]
        public ActionResult<List<Student>> GetMethod([FromQuery]string name){
            return Students.Where(x => x.Name == name).ToList();
            
        }
        [HttpPost]
        public ActionResult<Student> PostMethod([FromBody]Student student){
            Students.Add(student);
            return student;
        }
        [HttpPut]
        public ActionResult<Student> PutMethod([FromBody]Student student){
            var s = Students.FirstOrDefault(x => x.Id == student.Id);
            if(s==null){
                return BadRequest("id not found");
            }
            s.Name = student.Name;
            return s;
        }
        [HttpDelete]
        public ActionResult DeleteMethod([FromQuery] int id){
            var s = Students.FirstOrDefault(x => x.Id == id);
            if(s==null){
                return BadRequest("id not found");
            }
            Students.Remove(s);
            return Ok($"{s} is remove");
        }
    }
}

public class Student{
    public int Id { get; set;}
    public string Name { get; set;}
}

