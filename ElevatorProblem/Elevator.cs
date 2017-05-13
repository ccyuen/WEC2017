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
        private int numPassengers;
        private int currentFloor;
        private int destinationFloor;
        /// <summary>
        /// 'U' = Up direction, 'D' = Down direction, 'S' = Stationary/Stopped, 'N' = null
        /// </summary>
        private char direction;
        private List<Event> events = new List<Event>();


        public Elevator()
        {
            numPassengers = -1;
            currentFloor = -1;
            destinationFloor = -1;
            direction = 'N';
            events = null;
        }

        public Elevator(List<Event> _events)
        {
            events = _events;
            numPassengers = 0;
            direction = 'S';
        }
    }
}
