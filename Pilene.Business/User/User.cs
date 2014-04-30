using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pilene.DataBase;

namespace Pilene.Business.User
{
    public class User : IUser
    {

        public string HelloWorld(string data)
        {
            return data;
        }

        public void CreateUser(string data)
        {
            CrudUser crudUser = new CrudUser();
            crudUser.CreatetUser(data);
            
        }
    }
}
