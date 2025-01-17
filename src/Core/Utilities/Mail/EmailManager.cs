﻿using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;
using MimeKit.Text;
using System;
using System.Linq;

namespace Core.Utilities.Mail
{
    public class EmailManager : IEmailService
    {
        private readonly IConfiguration _configuration;
        public EmailManager(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void Send(EmailMessage emailMessage)
        {
            var message = new MimeMessage();
            message.To.AddRange(emailMessage.ToAddresses.Select(x => new MailboxAddress(x.Name, x.Address)));
            message.From.AddRange(emailMessage.FromAddresses.Select(x => new MailboxAddress(x.Name, x.Address)));

            message.Subject = emailMessage.Subject;

            var messageBody = string.Format(emailMessage.Subject, emailMessage.Content);
            message.Body = new TextPart(TextFormat.Html)
            {
                Text = messageBody
            };
            using (var emailClient = new SmtpClient())
            {
                emailClient.Connect(_configuration.GetSection("EmailConfiguration").GetSection("SmtpServer").Value,
                    Convert.ToInt32(_configuration.GetSection("EmailConfiguration").GetSection("SmtpPort").Value),
                    MailKit.Security.SecureSocketOptions.Auto);
                emailClient.Send(message);
                emailClient.Disconnect(true);
            }
        }
    }
}
