using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory6
{
    public class Computer
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string HDD_SSD { get; set; }
        public string GPU { get; set; }
        public string OS { get; set; }
        public string CoolingType { get; set; }
        public string PowerSupply { get; set; }
        public override string ToString()
        {
            return string.Format("CPU: {0}, RAM: {1}, HDD/SSD: {2}, GPU: {3}, OS: {4}, Cooling Type: {5}, Power Supply: {6}", CPU, RAM, HDD_SSD, GPU, OS, CoolingType, PowerSupply);
        }
    }
}
