using Microsoft.AspNetCore.Identity.UI.Services;

namespace Day6.Helpers
{
    public class MyEmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Task.CompletedTask;
        }
    }
}
