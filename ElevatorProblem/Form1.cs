using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace ElevatorProblem
{
    public partial class Form1 : Form
    {
        private static int i = 0;
        public Form1()
        {
            //String path = Path.GetFullPath(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\elevator_practice1.json"));
            //Debug.WriteLine("Path: " + path + '\n');
            //FileIO.readFromJsonFile(path);
            //Utils.printEvents(FileIO._events);
            
            // start the system clock once the program runs
            System.Timers.Timer time = new System.Timers.Timer();
            time.Interval = 1000;
            time.Enabled = true;
            time.AutoReset = true;
            time.Elapsed += new ElapsedEventHandler(counter);

        }

        public static void counter(object source, ElapsedEventArgs e)
        {
            i++;
            Debug.WriteLine("Counter: " + i);
        }
    }
}
