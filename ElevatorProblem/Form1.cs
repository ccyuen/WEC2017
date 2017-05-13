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

namespace ElevatorProblem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            String path = Path.GetFullPath(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\elevator_practice1.json"));
            //Debug.WriteLine("Path: " + path + '\n');
            FileIO.readFromJsonFile(path);
            //Utils.printEvents(FileIO._events);
        }
    }
}
