using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProblem
{

	class Algorithm
    {
		Elevator e1;
		Elevator e2;
		Elevator e3;
		Elevator e4;
		Elevator e5;
		List<Elevator> elevatorList;

		public Algorithm(List<Elevator> elevators){
            this.elevatorList = elevators;

		}

        public void eligible(ref List <Elevator> elevatorList, List <Event> eventList){

            //go through event list and check each elevator for that event
			foreach (Event element in eventList)
			{
				foreach (Elevator elevator in elevatorList)
			    {

                    //check each elevator if it is eligible for the event and adds to an eligible event list
                    if (elevator.direction == element.direction || elevator.direction == 'S')
                    {
                        if (elevator.direction == 'U' && elevator.currentFloor <= element.start && elevator.numPassengers < 5)
                        {
                            elevator.eligible = true;
                        }
                        else if (elevator.direction == 'D' && elevator.currentFloor >= element.start && elevator.numPassengers < 5)
                        {
							elevator.eligible = true;
						}
                        else if (elevator.direction == 'S' && elevator.numPassengers < 5)
                        {
							elevator.eligible = true;
						}
                    }
				}
			}
        }

        public Elevator efficiency(List <Elevator> elevatorList, List <Event> eventList){
            int shortestTime = 999999;
            int stopCount = 0;
            int travelTime = 0;

            foreach (Event element in eventList){
				foreach (Elevator elevator in elevatorList)
				{

					//only check elevator efficiency for eligible elevators
					if (elevator.eligible)
					{

						if (elevator.state == 'M')
						{
							foreach (Event elevatorElement in elevator.events)
							{
								if (elevator.direction == 'U' && elevatorElement.end >= elevator.currentFloor)
								{
									stopCount++;
								}
								else if (elevator.direction == 'D' && elevatorElement.end <= elevator.currentFloor)
								{
									stopCount++;
								}
							}

							//travelTime = stopCount * 10 + Math.Abs(elevator.currentFloor - )
	

					}
						//else if (elevator.state)


				}
				}


			}

		}

        /// <summary>
        /// Checks the events.
        /// </summary>
        /// <returns><c>true</c>, if events was checked, <c>false</c> otherwise.</returns>
        /// <param name="eventList">Event list.</param>
        /// <param name="currentTime">Current time.</param>
        /// 
        public List <Event> checkEvents(List <Event> eventList, int currentTime){
			List<Event> eligibleEvents = new List<Event>();

			//check each event if it's the time for the event
			foreach(Event element in eventList){
                if (element.time == currentTime){
                    eligibleEvents.Add(element);
                }
            }

            return eligibleEvents;

        }

    }
}
