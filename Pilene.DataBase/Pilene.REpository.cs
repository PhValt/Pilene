using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilene.DataBase
{
    public class Class1
    {
        User user = new User();
        public void insertUser()
        {
            UserDataContext ctx = new UserDataContext();
            user.Nom = "Romain";

            ctx.User.InsertOnSubmit(user);
            ctx.SubmitChanges();

        }
    }
}
