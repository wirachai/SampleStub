using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleStub
{
    public interface IUserRepository
    {
        bool IsExist(string username, string password);
    }
}
