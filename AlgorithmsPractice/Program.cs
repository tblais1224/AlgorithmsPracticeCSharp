using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // given a starting hour and number or hours passed display the following: 
            //    the hour is now x:00 and y days have passed 
            //   constraints =    starting hour: 1 <= x <= 12      hours passed: 1 <= y <= intMax   challenge: intMin <= y <= intMax

            var timeMachine = new TimeMachine(3, 261);
            Console.WriteLine(timeMachine.GetTime());
        }
    }
}
