using JSG.Email.Models;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace JSG.Email
{
    public class Email
    {
        private readonly GoogleEmailDetails _googleEmailDetails;
        private const string googleHost = "smtp.gmail.com";

        public Email(GoogleEmailDetails googleEmailDetails)
        {
            _googleEmailDetails = googleEmailDetails;
        }

        /// <summary>
        /// Sends an email to a recipient
        /// </summary>
        public void SendMail()
        {
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = googleHost;
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(_googleEmailDetails.GoogleUserName, _googleEmailDetails.GooglePassword);
            MailMessage mm = new MailMessage(_googleEmailDetails.From, _googleEmailDetails.To, _googleEmailDetails.Subject, _googleEmailDetails.Body);
            mm.BodyEncoding = Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.Send(mm);
        }
    }
}