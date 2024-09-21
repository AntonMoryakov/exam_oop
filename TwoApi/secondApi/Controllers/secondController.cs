using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net;


namespace secondApi.Controllers{
    [Route("home")]
    [ApiController]
    public class HomeController : Controller{
        private readonly HttpClient _httpClient;
        public HomeController(IHttpClientFactory httpClientFactory){
            _httpClient = httpClientFactory.CreateClient();
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetMethod(){
            var response = await _httpClient.GetAsync("http://localhost:5182/home/GetMethod");
            if(response.StatusCode == HttpStatusCode.OK){
                var result = await response.Content.ReadFromJsonAsync<IEnumerable<Student>>();
                return Json(result);
            }
            else{
                return BadRequest(await response.Content.ReadAsStringAsync());
            }
        }
    }
    public class Student{
            public int Id{ get; set; }
            public string Name { get; set;}
            public string Description { get; set;}
    }
}