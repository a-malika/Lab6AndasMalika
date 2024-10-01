using Laboratory6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory6
{
    public class GamingComputerBuilder : IComputerBuilder
    {
        private Computer computer = new Computer();
        public void SetCPU()
        {
            computer.CPU = "мощный";
        }
        public void SetRAM()
        {
            computer.RAM = "32GB";
        }
        public void SetHDD_SSD()
        {
            computer.HDD_SSD = "SSD";
        }
        public void SetGPU()
        {
            computer.GPU = "дискретная";
        }
        public void SetOS()
        {
            computer.OS = "Linux";
        }
        public void SetCoolingType()
        {
            computer.CoolingType = "жидкостное";
        }
        public void SetPowerSupply()
        {
            computer.PowerSupply = "750W";
        }
        public Computer GetComputer()
        {
            return computer;
        }
    }
}
