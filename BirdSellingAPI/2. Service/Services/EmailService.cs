using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._4._Core.Model.EmailSettingModel;
using System.Net;
using System.Net.Mail;

namespace BirdSellingAPI._2._Service.Services
{
    public class EmailService : IEmailService
    {
        public EmailService() { }
        public void SendEmail(SendMailModel sendMailModel)
        {
            try
            {
                MailMessage message = new MailMessage()
                {
                    Subject = sendMailModel.Subject,
                    Body = sendMailModel.Content,
                    IsBodyHtml = false
                };
                message.From = new MailAddress(EmailSettingModel.Instance.FromEmailAddress, EmailSettingModel.Instance.FromDisplayName);
                message.To.Add(sendMailModel.ReceiveAddress);

                var smtp = new SmtpClient()
                {
                    EnableSsl = EmailSettingModel.Instance.Smtp.EnableSsl,
                    Host = EmailSettingModel.Instance.Smtp.Host,
                    Port = EmailSettingModel.Instance.Smtp.Port,
                };

                var network = new NetworkCredential(EmailSettingModel.Instance.Smtp.EmailAddress, EmailSettingModel.Instance.Smtp.Password);
                smtp.Credentials = network;
                smtp.Send(message);
            }
            catch
            {
                throw;
            }

        }

        public string GenerateRandomKey ()
        {
            Random random = new Random();

            // Tạo chuỗi 6 số ngẫu nhiên
            string randomString = "";
            for (int i = 0; i < 6; i++)
            {
                randomString += random.Next(0, 10); // Tạo số ngẫu nhiên từ 0 đến 9 và thêm vào chuỗi
            }
            return randomString;
        }

    }
}
