namespace QuanLyNghiPhep.WebApp.Services
{
    public interface IMessageService
    {
        void SetMessage(string message, string type = "success");
    }
}
