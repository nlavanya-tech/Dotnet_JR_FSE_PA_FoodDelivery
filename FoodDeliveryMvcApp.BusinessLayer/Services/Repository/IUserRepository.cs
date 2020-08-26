using FoodDeliveryMvcApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryMvcApp.BusinessLayer.Services.Repository
{
    public interface IUserRepository
    {
        Task<Login> UserloginReadAsync(Login login);
        Task<SignUp> UserSignUpCreateAsync(SignUp signup);
    }
}
