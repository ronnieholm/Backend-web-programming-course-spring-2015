using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDemo
{
    // general pattern implementation with non-domain specific class name
    public class Singleton
    {
        private static Singleton _instance;

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                // lazily initialize singleton instance
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
    }

    // actual implementation with domain specific class name
    public class SomeAppMySqlDatabaseConnection
    {
        private static SomeAppMySqlDatabaseConnection _instance;

        private SomeAppMySqlDatabaseConnection() { }

        public static SomeAppMySqlDatabaseConnection Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SomeAppMySqlDatabaseConnection();
                }
                return _instance;
            }
        }

        public List<Customer> GetCustomers()
        {
            return new List<Customer>();
        }
    }        

    public class Customer
    {
        // various properties of customer
    }
}
