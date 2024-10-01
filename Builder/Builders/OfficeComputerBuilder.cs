using Laboratory6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory6
{
    public class OfficeComputerBuilder : IComputerBuilder
    {
        private Computer computer = new Computer();
        public void SetCPU()
        {
            computer.CPU = "простой";
        }
        public void SetRAM()
        {
            computer.RAM = "8GB";
        }
        public void SetHDD_SSD()
        {
            computer.HDD_SSD = "HDD";
        }
        public void SetGPU()
        {
            computer.GPU = "встроенная";
        }
        public void SetOS()
        {
            computer.OS = "Linux";
        }
        public void SetCoolingType()
        {
            computer.CoolingType = "воздушное";
        }
        public void SetPowerSupply()
        {
            computer.PowerSupply = "400W";
        }
        public Computer GetComputer()
        {
            return computer;
        }
    }
}
