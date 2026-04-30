//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;

//namespace QuestGameDetective.API.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class TestController : ControllerBase
//    {
//        [HttpGet("public")]
//        public IActionResult Public()
//        {
//            return Ok("Detta är en öppen endpoint");
//        }

//        [Authorize]
//        [HttpGet("private")]
//        public IActionResult Private()
//        {
//            return Ok("Du är inloggad och har giltig token");
//        }
//    }
//}
