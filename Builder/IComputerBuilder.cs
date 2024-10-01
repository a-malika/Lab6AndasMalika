using Laboratory6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory6
{
    public interface IComputerBuilder
    {
        void SetCPU();
        void SetRAM();
        void SetHDD_SSD();
        void SetGPU();
        void SetOS();
        void SetCoolingType();
        void SetPowerSupply();
        Computer GetComputer();
    }
}
