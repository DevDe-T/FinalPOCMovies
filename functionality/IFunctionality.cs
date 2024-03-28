using finalPOCService.models;
 
namespace finalPOCService.Functionality
{
    public interface IFunctionality
    {
        int accountCreate(User user);
        bool accountLogin(User user);
    }
}