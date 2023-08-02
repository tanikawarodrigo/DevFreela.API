using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Core.Entities;
using DevFreela.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly DevFreelaDbContext _dbContext;
        public UserService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Create(NewUserInputModel newUserInputModel)
        {
            var user = new User(newUserInputModel.Name, newUserInputModel.Email, newUserInputModel.BirthDate);

            _dbContext.Users.Add(user);

            return user.Id;
        }

        public List<UserViewModel> GetAll()
        {
            var users = _dbContext.Users;

            var userViewModel = users.Select(u => new UserViewModel(u.Name,u.Email,u.BirthDate)).ToList();

            return userViewModel;
        }

        public UserViewModel GetById(int id)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Id == id);

            var userViewModel = new UserViewModel(user.Name,user.Email,user.BirthDate);

            return userViewModel;
        }

        public void Login(LoginInputModel loginInputModel)
        {
            throw new NotImplementedException();
        }
    }
}
