using Microsoft.AspNetCore.Mvc;

namespace _02_hello_mvc.Controllers
{
    [Route("")]
    public class HomeControler : Controller
    {
        [HttpGet]
        public string Index()
        {
            return "Hello world!";
        }

        [HttpGet("Echo/{message?}")]
        public string Echo(string message)
        {
            return $"Echo: {message}";
        }
    }
}