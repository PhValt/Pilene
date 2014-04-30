using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilene.DataBase
{
    public class CrudUser
    {
        User user = new User();

        public void CreatetUser(string data)
        {
            UserDataContext ctx = new UserDataContext();
            user.Nom = data;

            ctx.User.InsertOnSubmit(user);
            ctx.SubmitChanges();

        }
    }
}
