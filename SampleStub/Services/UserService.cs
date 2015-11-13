using SampleStub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleStub
{
    public class UserService
    {
        public IUserRepository UserRepository { get; set; }
        public bool IsValidLogin(LoginModel model)
        {
            // some validation

            return UserRepository.IsExist(model.Username, model.Password);
        }
    }
}
