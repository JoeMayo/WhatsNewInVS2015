using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EditorDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 2;

            DoSomething();

            for (int i = 0; i < count; i++)
            {
                DoSomething();
            }
        }

        static void DoSomething()
        {
            int milliseconds = 1000;
            Thread.Sleep(milliseconds);

            //DoSomethingElse(1000, "message");
        }

        static void DoSomethingElse(int milliseconds, string message)
        {
            Thread.Sleep(1000);
        }
    }
}
