using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Pilene.WebService.User
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IServiceUser" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IServiceUser
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        string HelloWorld(string data);

        [OperationContract]
        void CreateUser(string data);
    }
}
