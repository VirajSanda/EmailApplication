using EmailApplication.Models;
using EmailApplication.Services.EmailServices;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;

namespace EmailApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;
        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;   
        }
        [HttpPost]
        public IActionResult SendMail(EmailDto body)
        {
            _emailService.SendEmail(body);
            return Ok();
        }
    }
}
