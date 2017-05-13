using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProblem
{
    class Utils
    {
        public static void printEvents(List<Event> events)
        {
            if (events != null)
            {
                int k = 1;
                foreach (Event e in events)
                {
                    Debug.WriteLine("Event #{0}: \nTime: {1} \nStart: {2} \nEnd: {3} \n", k, e.time, e.start, e.end);
                    k++;
                }
            }
            else
            {
                Debug.WriteLine("Empty!");
            }
        }
    }
}
