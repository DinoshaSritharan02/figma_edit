using Backend.Models;
namespace Backend.Services.Interfaces


{
    public interface IUserService
    {
        List<User> GetAllUsers();
    }
}
