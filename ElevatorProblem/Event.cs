﻿using System;
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
        public int time;
        public int start;
        public int end;
		/// <summary>
		/// 'U' = Up direction, 'D' = Down direction, 'N' = null
		/// </summary>
		public char direction;
        public int Time{ get; }
        public int Start{ get; }
        public int End{ get; }

        public Event() {
            time = -1;
            start = -1;
            end = -1;
        }

        public Event(int _time, int _start, int _end) {
            time = _time;
            start = _start;
            end = _end;

            int diff = end - start;

            if (diff > 0){
                direction = 'U';
            }
            else if (diff < 0){
                direction = 'D';
            }

        }
    }
}
