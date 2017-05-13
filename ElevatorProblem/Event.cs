using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProblem
{
    /// <summary>
    /// This class contains the object that holds the information for each event
    /// </summary>
    class Event
    {
        private int time;
        private int start;
        private int end;

        public Event() {
            time = -1;
            start = -1;
            end = -1;
        }

        public Event(int _time, int _start, int _end) {
            time = _time;
            start = _start;
            end = _end;
        }
    }
}
