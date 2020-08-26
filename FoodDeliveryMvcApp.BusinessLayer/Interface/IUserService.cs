using FoodDeliveryMvcApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryMvcApp.BusinessLayer.Interface
{
   public interface IUserService
    {
        Task<Login> UserloginReadAsync(Login login);
        Task<SignUp> UserSignUpCreateAsync(SignUp signup);
    }
}
