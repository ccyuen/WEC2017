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
    class Elevator
    {
        public int numPassengers;
        public int currentFloor;
        public int finalFloor;
        public int numStops;
        /// <summary>
        /// 'U' = Up direction, 'D' = Down direction, 'S' = Stationary/Stopped, 'N' = null
        /// </summary>
        public char direction;
        /// <summary>
        /// 'S' = stopped, 'M' = moving, 'N' = no mission
        /// </summary>
        public char state;
        public bool eligible;
        public List<Event> events = new List<Event>();


        public Elevator()
        {
            numPassengers = 0;
            currentFloor = 0;
            finalFloor = 0;
            numStops = 0;
            direction = 'S';
            state = 'N';
            events = null;
            eligible = false;
        }

    }
}
