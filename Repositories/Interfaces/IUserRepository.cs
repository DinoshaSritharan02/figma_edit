using Backend.Models;
namespace Backend.Repositories.Interfaces

{
    public interface IUserRepository
    {
        List <User> GetAllUsers();
    }
}
