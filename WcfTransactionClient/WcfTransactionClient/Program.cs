using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace WcfTransactionClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            //--- Introduce console program ---
            Console.WriteLine("--- WCF TRANSACTION ---");
            Console.WriteLine("Press enter to start process...");
            var name = Console.ReadLine();

            //List of users to create
            var users = new List<User> {
                new User{Name = "Kmille"},
                new User{Name = "Laurentt"},
                new User{Name = "Agathe"}
            };

            //Call complex process to create user
            CreateUsers(users);

            //--- End of the program ---
            Console.WriteLine("--- END OF WCF TRANSACTION  (PRESS ENTER) ---");
            Console.ReadLine();
        }

        /// <summary>
        /// Create users (suppose complex process)
        /// </summary>
        /// <param name="users"></param>
        public static void CreateUsers(List<User> users)
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var dbAContext = new DbAEntities();
                try
                {
                    foreach (var user in users)
                    {
                        //DbB modification : WCF call
                        var wcfTransactSvc = new WcfTransactionService.Service1Client();
                        wcfTransactSvc.CreateDefaultUser();
                        var result = wcfTransactSvc.CreateUser(user.Name + "123");
                        if (!result)
                        {
                            throw new Exception("");
                        }
                        //DbA modification : local
                        dbAContext.User.Add(user);
                    }
                    //SAVE LOCALLY
                    dbAContext.SaveChanges();
                    //SAVE ON WCF
                    ts.Complete();
                }
                catch (Exception e)
                {
                    Trace.TraceError("ERROR DURING CREATION", e);
                }
                finally
                {
                    ts.Dispose();
                    dbAContext.Dispose();
                }
            }
        }

        /// <summary>
        /// Create one user
        /// </summary>
        /// <param name="user"></param>
        public void CreateUser(User user)
        {

        }
    }
}
