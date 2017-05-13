using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProblem
{
    class Time
    {
        private static DateTime time = DateTime.Now;
        
        public static void getTime()
        {
            Debug.WriteLine(time.ToString());
        }
    }
}
