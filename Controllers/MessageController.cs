using Microsoft.AspNetCore.Mvc;
using YOApi.Data.Interfaces;
using YOApi.Models.Message;

namespace YOApi.Controllers
{
    [ApiController]
    [Route("message")]
    public class MessageController : ControllerBase
    {
        private readonly IMessageRepository _messageRepository;

        public MessageController(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Message> GetMessageById(int id)
        {
            var message = _messageRepository.GetMessageById(id);
            if (message != null)
            {
                return Ok(message);
            }
            return NotFound();
        }

        [HttpPost]
        [Route("create")]
        public ActionResult CreateMessage(Message message)
        {
            _messageRepository.CreateMessage(message);
            return Ok();
        }
    }
}