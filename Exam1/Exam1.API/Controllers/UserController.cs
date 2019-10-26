using Exam1.Data.Interfaces;
using Exam1.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exam1.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var users = _userRepository.GetAll();
            return new JsonResult(users);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            var result = _userRepository.Find(user.Id);
            if (result==null)
            {
                _userRepository.Add(user);
            }
                       
            return new JsonResult(user);
        }

    }
}
