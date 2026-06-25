using Backend.Repositories.Interfaces;
using Backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Backend.Models;

namespace Backend.Services.Implementations
{

    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        public List<User> GetAllUsers()
        {
            return _repository.GetAllUsers();
        }
    }
}
