using FoodDeliveryMvcApp.BusinessLayer.Interface;
using FoodDeliveryMvcApp.BusinessLayer.Services;
using FoodDeliveryMvcApp.BusinessLayer.Services.Repository;
using FoodDeliveryMvcApp.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace FoodDeliveryMvcApp.Test.TestCases
{
    public class Functional
    {
        private IUserService _userservices;
        private IRestorentService _services;
        public readonly Mock<IUserRepository> userservice = new Mock<IUserRepository>();
        public readonly Mock<IRestorentRepository> service = new Mock<IRestorentRepository>();
        static Functional()
        {
            if (!File.Exists("../../../../output_revised.txt"))
                try
                {
                    File.Create("../../../../output_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_revised.txt");
                File.Create("../../../../output_revised.txt").Dispose();
            }
        }
        public Functional()
        {
            _userservices = new UserService(userservice.Object);
            _services = new RestorentService(service.Object);
        }
        Random random = new Random();
        [Fact]
        public async void Test_getUserlogin()
        {
            //assigning value
            bool finalresult = false;
            var login = new Login()
            {
                UserId = "lavanya2@gmail.com",
                Password = "lava@123",
            };
            //setup
            userservice.Setup(repo => repo.UserloginReadAsync(login));
            var result = await _userservices.UserloginReadAsync(login);
            if (result != null) { finalresult = true; }

            //finalresult displaying in text file
            File.AppendAllText("../../../../output_revised.txt", "Test_getUserlogin=" + finalresult + "\n");

            Assert.NotNull(result);

        }
        [Fact]
        public async void Test_validateUserSignUp()
        {
            //assigning value
            bool finalresult = false;
            var signup = new SignUp()
            {
                FirstName = "N",
                LastName = "lava",
                EmailId = "Nlavanya@gmail.com",
                PhoneNumber = "12335",
                NewPassword = "lava@123",
            };
            //setup
            userservice.Setup(repo => repo.UserSignUpCreateAsync(signup));
            var result = await _userservices.UserSignUpCreateAsync(signup);
            if (result != null) { finalresult = true; }

            //finalresult displaying in text file
            File.AppendAllText("../../../../output_revised.txt", "Test_validateUserSignUp=" + finalresult + "\n");

            Assert.NotNull(result);

        }
        [Fact]
        public async void Test_UserSignUp()
        {
            //assigning value
            bool finalresult = false;
            var signup = new SignUp()
            {
                FirstName = "N",
                LastName = "lava",
                EmailId = "Nlavanya@gmail.com",
                PhoneNumber = "12335",
                NewPassword = "lava@123",
            };
            //setup
            userservice.Setup(repo => repo.UserSignUpCreateAsync(signup));
            var result = await _userservices.UserSignUpCreateAsync(signup);
            if (result == signup) { finalresult = true; }

            //finalresult displaying in text file
            File.AppendAllText("../../../../output_revised.txt", "Test_UserSignUp=" + finalresult + "\n");

            Assert.Equal(result, signup);

        }
        [Fact]
        public async void Test_RestorentCreate()
        {
            //assigning value
            bool finalresult = false;
            var restorent = new Restorents()
            {
                RestorentName = "vishnu bhavan",
                address = "chittor",
                reviews = "4",
            };
            //setup
            service.Setup(repo => repo.RestorentCreateAsync(restorent));
            var result = await _services.RestorentCreateAsync(restorent);
            if (result == restorent) { finalresult = true; }

            //finalresult displaying in text file
            File.AppendAllText("../../../../output_revised.txt", "Test_RestorentCreate=" + finalresult + "\n");

            Assert.Equal(result, restorent);

        }
        [Fact]
        public async void Test_validatingAddRestorent()
        {
            //assigning value
            bool finalresult = false;
            var restorent = new Restorents()
            {
                RestorentName = "vishnu bhavan",
                address = "chittor",
                reviews = "4",
            };
            //setup
            service.Setup(repo => repo.RestorentCreateAsync(restorent));
            var result = await _services.RestorentCreateAsync(restorent);
            if (result != null) { finalresult = true; }

            //finalresult displaying in text file
            File.AppendAllText("../../../../output_revised.txt", "Test_validatingAddRestorent=" + finalresult + "\n");

            Assert.NotNull(result);

        }
        [Fact]
        public async void Test_validatingFooditemCreate()
        {
            //assigning value
            bool finalresult = false;
            var fooditems = new FoodIteam()
            {
                RestorentName = "vishnu bhavan",
                FoodItem = "dosa",
                Cost = 4,
                Address = "chittor"
            };
            //setup
            service.Setup(repo => repo.FooditemCreateAsync(fooditems));
            var result = await _services.FooditemCreateAsync(fooditems);
            if (result != null) { finalresult = true; }

            //finalresult displaying in text file
            File.AppendAllText("../../../../output_revised.txt", "Test_validatingFooditemCreate=" + finalresult + "\n");

            Assert.NotNull(result);

        }
        [Fact]
        public async void Test_FooditemCreate()
        {
            //assigning value
            bool finalresult = false;
            var fooditems = new FoodIteam()
            {
                RestorentName = "vishnu bhavan",
                FoodItem = "dosa",
                Cost = 4,
                Address = "chittor"
            };
            //setup
            service.Setup(repo => repo.FooditemCreateAsync(fooditems));
            var result = await _services.FooditemCreateAsync(fooditems);
            if (result == fooditems) { finalresult = true; }

            //finalresult displaying in text file
            File.AppendAllText("../../../../output_revised.txt", "Test_validatingFooditemCreate=" + finalresult + "\n");

            Assert.Equal(result, fooditems);

        }


    }
}
