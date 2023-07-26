using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDDD.Infra.CrossCutting.Identity.Services
{
    public class AuthEmailMessageSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {

            return Task.FromResult(0);
        }
    }

    public class AuthSMSMessageSender : ISmsSender
    {
        public Task SendSmsAsync(string number, string message)
        {

            return Task.FromResult(0);
        }
    }
}
