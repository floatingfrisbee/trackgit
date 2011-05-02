using System.Net;
using System.Net.Mail;
using trackgit.Models;

namespace trackgit.Helpers
{
    public class EmailHelper
    {
        public const string SendEmailAccount = "mailer@opspark.com";
        public const string SendEmailPwd = "5mrdma1l";
        public const string SendEmailHost = "smtp.gmail.com";
        public const int SendEmailPort = 587;

        internal static void SendEmail(Checkin checkin)
        {
            using (var mailMessage = new MailMessage(SendEmailAccount, checkin.User.EmailId, "hello subject", "hello body"))
            {
                mailMessage.IsBodyHtml = false;

                using (var smtpClient = new SmtpClient(SendEmailHost, SendEmailPort)
                {
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(SendEmailAccount, SendEmailPwd)
                })
                {
                    mailMessage.IsBodyHtml = false;
                    smtpClient.Send(mailMessage);
                }
            }
        }
    }
}