using BirdSellingAPI._4._Core.Model.EmailSettingModel;

namespace BirdSellingAPI._2._Service.IServices
{
    public interface IEmailService
    {
        public void SendEmail(SendMailModel sendMailModel);
        public string GenerateRandomKey();
    }
}
