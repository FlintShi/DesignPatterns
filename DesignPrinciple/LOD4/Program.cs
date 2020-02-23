using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOD4
{
    class Program
    {
        static void Main(string[] args)
        {
            InstallSoftware invoker = new InstallSoftware();
            invoker.installWizard(new Wizard());
            Console.ReadLine();
        }
    }
}
