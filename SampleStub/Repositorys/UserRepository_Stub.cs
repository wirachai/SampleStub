using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleStub
{
    public class UserRepository_Stub : IUserRepository
    {
        public bool ShouldBeValid { get; set; }
        public bool IsExist(string username, string password)
        {
            return ShouldBeValid;
        }
    }
}
