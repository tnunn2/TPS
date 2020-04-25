using System;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace TPS.Services
{
    public class EmailService : IEmailService
    {
        private IWebHostEnvironment Env { get; }
        public EmailService(IWebHostEnvironment env)
        {
            Env = env;
        }
        public Task SendAsync(string email, string messageBody)
        {
            var sendGridUserName = "apikey";
            var sentFrom = "helpdesk@tps.com";
            var sendGridPassword = "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";

            // Configure the client:
            var client = new SmtpClient("smtp.sendgrid.net", Convert.ToInt32(587));
            //587
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;

            // Create the credentials:
            System.Net.NetworkCredential credentials =
                new System.Net.NetworkCredential(sendGridUserName, sendGridPassword);
            client.EnableSsl = true; client.Credentials = credentials;

            string body = System.IO.File.ReadAllText(Env.ContentRootPath + "/Templates/mailHtmlTemplate.html");
            body = body.Replace("{{email_address}}", "thomasnunneryjr@msn.com");
            var mail = new System.Net.Mail.MailMessage(new MailAddress(sentFrom), new MailAddress(email)); 
            mail.Subject = "Reset Password";
            mail.IsBodyHtml = true;
            mail.Body = messageBody;
            

            // Send: 
            return client.SendMailAsync(mail);
        }
    }
    
}
