using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // singleton
            SomeAppMySqlDatabaseConnection s1 = SomeAppMySqlDatabaseConnection.Instance;
            SomeAppMySqlDatabaseConnection s2 = SomeAppMySqlDatabaseConnection.Instance;
            Console.WriteLine(Object.ReferenceEquals(s1, s2));
            List<Customer> customers = s1.GetCustomers();

            // template
            SomeTemplate template = new SomeTemplate();
            template.Execute();
        }
    }
}
