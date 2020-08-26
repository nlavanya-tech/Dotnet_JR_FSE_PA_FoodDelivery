using FoodDeliveryMvcApp.BusinessLayer.Interface;
using FoodDeliveryMvcApp.BusinessLayer.Services.Repository;
using FoodDeliveryMvcApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryMvcApp.BusinessLayer.Services
{
   public class UserService:IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        public async Task<Login> UserloginReadAsync(Login login)
        {
            var user = await _repository.UserloginReadAsync(login);
            return login;
        }
        public async Task<SignUp> UserSignUpCreateAsync(SignUp signup)
        {
            var userdetails = await _repository.UserSignUpCreateAsync(signup);
            return signup;

        }
        }
}
