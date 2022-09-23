using Microsoft.AspNetCore.Mvc;
using YOApi.Data.Interfaces;
using YOApi.Models.Message;

namespace YOApi.Controllers
{
    [ApiController]
    [Route("messages")]
    public class UserMessagesController : ControllerBase
    {
        private readonly IUserMessagesRepository _userMessagesRepository;
        private readonly IUserRepository _userRepository;

        public UserMessagesController(IUserMessagesRepository userMessagesRepository, 
                                      IUserRepository userRepository)
        {
            _userMessagesRepository = userMessagesRepository;
            _userRepository = userRepository;
        }

        [HttpGet]
        [Route("incoming/{id}")]
        public ActionResult<MessagesBox> GetAllIncomingsByUserId(int id)
        {
            if (!_userRepository.CheckUserById(id))
            {
                return NotFound();
            }

            var messages = _userMessagesRepository.GetMessagesByUserIdWithSelection(id, "incoming");
            
            return Ok(messages);
        }

        [HttpGet]
        [Route("sent/{id}")]
        public ActionResult<MessagesBox> GetAllSenterByUserId(int id)
        {
            if (!_userRepository.CheckUserById(id))
            {
                return NotFound();
            }

            var messages = _userMessagesRepository.GetMessagesByUserIdWithSelection(id, "sent");
            
            return Ok(messages);
        }

    }
}