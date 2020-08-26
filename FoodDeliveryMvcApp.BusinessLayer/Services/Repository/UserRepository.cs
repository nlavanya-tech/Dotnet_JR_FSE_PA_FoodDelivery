using FoodDeliveryMvcApp.DataLayer;
using FoodDeliveryMvcApp.Entities;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryMvcApp.BusinessLayer.Services.Repository
{
    public class UserRepository : IUserRepository
    {
        private InMemoryDb DbContext;
        public UserRepository(InMemoryDb DbContext)
        {
            this.DbContext = DbContext;
        }
        public async Task<Login> UserloginReadAsync(Login login)
        {
            var userlogindetails = login;
            var userid = this.DbContext.signup.FirstOrDefault(e => e.EmailId == login.UserId);
            if (userid.EmailId != null && userid.EmailId != "")
            {
                var users = this.DbContext.signup.FirstOrDefault(e => e.NewPassword == login.Password);
                if (users.NewPassword != null && users.NewPassword != "")
                {
                    userlogindetails.UserId = users.EmailId;
                    userlogindetails.Password = users.NewPassword;
                }

            }
            else
            {
                userlogindetails.UserId = null;
                userlogindetails.Password = null;
            }
            return login;
        }
        public async Task<SignUp> UserSignUpCreateAsync(SignUp signup)
        {
            this.DbContext.signup.Add(signup);
            this.DbContext.SaveChanges();
            return signup;
        }

        }
}
