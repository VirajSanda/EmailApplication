using EmailApplication.Models;

namespace EmailApplication.Services.EmailServices
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
    }
}
