using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;

namespace ElevatorProblem
{
    class FileIO
    {
        private static List<Event> _events = null;
        //private String filePath = Path.GetFullPath(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, @"..\"));
        // goes to the directory one level above the current project directory (i.e. the git repo folder)
        private static int totalEvents;

        public static void readFromJsonFile(String path)
        {
            _events = new List<Event>();
            JObject jo = JObject.Parse(File.ReadAllText(path));
            totalEvents = jo["events"].Count();

            for (int k = 0; k < totalEvents; k++)
            {
                Event e = new Event(jo["events"][k]["time"].Value<int>(), 
                    jo["events"][k]["start"].Value<int>(), 
                    jo["events"][k]["end"].Value<int>());
                _events.Add(e);
            }
        }

        /// <summary>
        /// Returns the list of events read from the JSON file (must be read in first or else null!)
        /// </summary>
        /// <returns></returns>
        public static List<Event> getEvents()
        {
            return _events;
        }


        /// <summary>
        /// Returns the number of events
        /// </summary>
        /// <returns></returns>
        public static int getNumEvents()
        {
            return totalEvents;
        }
    }
}
