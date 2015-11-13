using NUnit.Framework;
using SampleStub;
using SampleStub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleStubTest
{
    [TestFixture]
    public class UserServiceTest
    {
        [Test]
        public void IsValidLogin_ShouldReturnTrue_WhenExistAccount()
        {
            // arrange
            UserRepository_Stub stub = new UserRepository_Stub();
            stub.ShouldBeValid = true;

            UserService service = new UserService();
            service.UserRepository = stub;

            // act
            LoginModel model = new LoginModel() { Username = "username", Password = "password" };
            bool result = service.IsValidLogin(model);

            // assert
            Assert.AreEqual(true, result);
        }
    }
}
