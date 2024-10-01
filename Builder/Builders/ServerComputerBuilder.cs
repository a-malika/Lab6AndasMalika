using Laboratory6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory6
{
    public class ServerComputerBuilder : IComputerBuilder
    {
        private Computer computer = new Computer();
        public void SetCPU()
        {
            computer.CPU = "сверхмощный серверный";
        }
        public void SetRAM()
        {
            computer.RAM = "128GB ECC";
        }
        public void SetHDD_SSD()
        {
            computer.HDD_SSD = "SSD RAID";
        }
        public void SetGPU()
        {
            computer.GPU = "отсутствует";
        }
        public void SetOS()
        {
            computer.OS = "Windows";
        }
        public void SetCoolingType()
        {
            computer.CoolingType = "жидкостное";
        }
        public void SetPowerSupply()
        {
            computer.PowerSupply = "1000W";
        }
        public Computer GetComputer()
        {
            return computer;
        }
    }
}
