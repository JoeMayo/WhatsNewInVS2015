using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugDemo
{
    public class Program
    {
        static int Main(string[] args)
        {
            int error = 0;

            error = ProcessStuff();

            Console.ReadKey();

            return error;
        }

        public static int ProcessStuff()
        {
            int error = 0;

            try
            {
                List<int> myIntList = new List<int>();

                double allAvg = 0;

                for (int i = 5; i > 0; i--)
                {
                    allAvg += Avg(10, i);
                    myIntList.Add(i);
                }

                Console.WriteLine($"Sum of Averages: {allAvg}");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.ToString());
                error = 13;
            }

            return error;
        }

        public static double Avg(int sum, int count)
        {
            return sum / count;
        }
    }
}
