using finalPOCService.Functionality;
using finalPOCService.models;
using Microsoft.AspNetCore.Mvc;
 
namespace finalPOCService.Controllers
{
    [ApiController]
    [Route("exl/[controller]")]
    public class UserController : ControllerBase
    {
        IFunctionality functionality;
        public UserController(IFunctionality _functionality)
        {
            functionality = _functionality;
        }
 
        [HttpPost]
        [Route("AccountCreate")]
        public IActionResult createAccount(User user)
        {
            return Ok(functionality.accountCreate(user));
        }
 
        [HttpPost("AccountLogin")]
        public IActionResult loginAccount(User user)
        {
            return Ok(functionality.accountLogin(user));
        }
    }
}