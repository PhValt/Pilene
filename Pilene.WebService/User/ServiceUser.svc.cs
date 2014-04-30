using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Pilene.WebService.User
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ServiceUser" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez ServiceUser.svc ou ServiceUser.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ServiceUser : IServiceUser
    {

        Business.User.User user;

        public void DoWork()
        {
        }


        public string HelloWorld(string data)
        {
            user = new Business.User.User();
            return user.HelloWorld(data);
        }


        public void CreateUser(string data)
        {
            user = new Business.User.User();
            user.CreateUser(data);
        }
    }
}
