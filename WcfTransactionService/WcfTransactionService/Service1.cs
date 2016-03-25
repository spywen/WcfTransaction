using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfTransactionService
{
    [ServiceBehavior(TransactionIsolationLevel = System.Transactions.IsolationLevel.Serializable)]
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class Service1 : IService1
    {
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        public bool CreateUser(string name)
        {
            try
            {
                var newUser = new User();
                newUser.Name = name;

                var test = new DbBEntities();
                test.User.Add(newUser);

                test.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Trace.TraceError("Error", e);
                return false;
            }
        }

        public bool CreateDefaultUser()
        {
            try
            {
                var newUser = new User();
                newUser.Name = "Default";

                var test = new DbBEntities();
                test.User.Add(newUser);

                test.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Trace.TraceError("Error", e);
                return false;
            }
        }
    }
}
