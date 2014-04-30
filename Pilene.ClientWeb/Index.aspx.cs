using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pilene.ClientWeb
{
    public partial class Index : System.Web.UI.Page
    {
        ServiceReferenceUser.ServiceUserClient serviceUser;

        protected void Page_Load(object sender, EventArgs e)
        {
            serviceUser = new ServiceReferenceUser.ServiceUserClient();
        }

        protected void ButtonHelloWorld_Click(object sender, EventArgs e)
        {
            serviceUser.CreateUser(TextBoxHelloWorld.Text);
        }
    }
}