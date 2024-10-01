using Laboratory6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory6
{
    public class ComputerDirector
    {
        private IComputerBuilder _computerBuilder;
        public ComputerDirector(IComputerBuilder computerBuilder)
        {
            this._computerBuilder = computerBuilder;
        }
        public void ConstructComputer()
        {
            _computerBuilder.SetCPU();
            _computerBuilder.SetRAM();
            _computerBuilder.SetHDD_SSD();
            _computerBuilder.SetGPU();
            _computerBuilder.SetOS();
            _computerBuilder.SetCoolingType();
            _computerBuilder.SetPowerSupply();
            ValidateComponents();
        }
        private void ValidateComponents()
        {
            Computer computer = _computerBuilder.GetComputer();
            if (computer.GPU == "дискретная" && computer.PowerSupply != "750W")
            {
                throw new InvalidOperationException("Дискретная графика требует блок питания минимум 750W");
            }
            if (computer.RAM == "128GB ECC" && computer.CPU != "сверхмощный серверный")
            {
                throw new InvalidOperationException("128GB ECC RAM совместима только с серверными процессорами");
            }
        }
        public Computer GetComputer()
        {
            return _computerBuilder.GetComputer();
        }
    }
}
