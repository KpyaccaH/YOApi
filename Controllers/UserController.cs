using Microsoft.AspNetCore.Mvc;
using YOApi.Data.Interfaces;
using YOApi.Models;

namespace YOApi.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpPost]
        [Route("create")]
        public ActionResult RegistrationUser(UserWithoutId user)
        {

            var check = _userRepository.CreateUser(user);
            if (check)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet]
        [Route("login")]
        public ActionResult AuthorizationUser(UserWithoutId user)
        {
            var check = _userRepository.Authorization(user);
            if (check)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}