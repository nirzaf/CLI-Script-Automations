using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI_Script_Automations
{
    public class Vehicle
    {
        public string VehicleNumber { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public int StartingSpeed { get; set; } = 0;

        public void Accelerate(string start)
        { 
            if(start == "Start")
            { 
                Console.WriteLine(StartingSpeed + 5);   
            }
        }



    }
}
