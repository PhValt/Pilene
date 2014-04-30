using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilene.Business.User
{
    public interface IUser
    {
        string HelloWorld(string data);
        void CreateUser(string data);
    }
}
