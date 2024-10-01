using Laboratory6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory6
{
    public class GraphicsWorkComputerBuilder : IComputerBuilder
    {
        private Computer computer = new Computer();
        public void SetCPU()
        {
            computer.CPU = "мощный";
        }
        public void SetRAM()
        {
            computer.RAM = "64GB";
        }
        public void SetHDD_SSD()
        {
            computer.HDD_SSD = "SSD + HDD";
        }
        public void SetGPU()
        {
            computer.GPU = "профессиональная";
        }
        public void SetOS()
        {
            computer.OS = "Windows";
        }
        public void SetCoolingType()
        {
            computer.CoolingType = "воздушное";
        }
        public void SetPowerSupply()
        {
            computer.PowerSupply = "850W";
        }
        public Computer GetComputer()
        {
            return computer;
        }
    }
}
