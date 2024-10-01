using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory6
{
    public class Program
    {
        static void Main(string[] args)
        {
            IComputerBuilder officeComp = new OfficeComputerBuilder();
            IComputerBuilder gamingComp = new GamingComputerBuilder();
            IComputerBuilder serverComp = new ServerComputerBuilder();
            IComputerBuilder graphicsComp = new GraphicsWorkComputerBuilder();
            ComputerDirector compDirOffice = new ComputerDirector(officeComp);
            ComputerDirector compDirGaming = new ComputerDirector(gamingComp);
            ComputerDirector compDirServer = new ComputerDirector(serverComp);
            ComputerDirector compDirGraphics = new ComputerDirector(graphicsComp);
            compDirOffice.ConstructComputer();
            compDirGaming.ConstructComputer();
            compDirServer.ConstructComputer();
            compDirGraphics.ConstructComputer();
            Computer resCompOffice = compDirOffice.GetComputer();
            Computer resCompGaming = compDirGaming.GetComputer();
            Computer resCompServer = compDirServer.GetComputer();
            Computer resCompGraphics = compDirGraphics.GetComputer();
            Console.WriteLine(resCompOffice);
            Console.WriteLine(resCompGaming);
            Console.WriteLine(resCompServer);
            Console.WriteLine(resCompGraphics);
        }
    }
}
