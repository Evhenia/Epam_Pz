using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memories
{
    class Program
    {
        static void Main(string[] args)
        {
            StudySadMemory ssm = new StudySadMemory(4, 4, 8, 3);
            Console.WriteLine(ssm.SadEducationalPlace);
            Console.WriteLine((int)ssm.SadEducationalPlace);

            Console.WriteLine(ssm.StrongOfMemory);

            Console.WriteLine(ssm.MemoryInfo());
            Console.ReadKey();
        }
    }
}
