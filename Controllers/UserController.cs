using Backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    { 
        private readonly IUserService _Service;
        public UserController(IUserService Service)
        {
            _Service = Service;
        }
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Ok(_Service.GetAllUsers());
        }
    }
    
}
