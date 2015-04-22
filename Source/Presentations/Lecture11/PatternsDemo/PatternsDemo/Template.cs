using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDemo
{
    abstract class Template
    {
        void Step1()
        {
            Console.WriteLine("Step 1 (cannot be overridden by subclass)");
        }

        public abstract void Step2();

        public virtual void Step3()
        {
            Console.WriteLine("Step 3 (can be overridden by subclass)");
        }

        public virtual void Step4()
        {
            Console.WriteLine("Step 4 (can be overridden by subclass)");
        }

        // actual template method
        public void Execute()
        {
            Step1();
            Step2();
            Step3();
            Step4();
        }
    }

    class SomeTemplate : Template
    {
        public override void Step2()
        {
            Console.WriteLine("Step 2 (must be overriden in subclass)");
        }

        public override void Step4()
        {
            Console.WriteLine("Step 4 (overriden i subclass)");
        }
    }

    // refer to http://bugfree.dk/blog/2010/01/11/sharepoint-list-definition-using-the-template-pattern
    // for real-world example of Template pattern in use.

    // also used in ASP.NET MVC/WebAPI for methods that execute before/after every controller method
}
