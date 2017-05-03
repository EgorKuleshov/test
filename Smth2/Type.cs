using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ConstrainedExecution;
using System.Diagnostics.Contracts;

namespace Smth2
{
    internal static class Type
    {
        static Type()
        {
            Console.WriteLine("Ctor");
        }
        [ReliabilityContract(Consistency.MayCorruptProcess, Cer.None)]
        public static void WriteSmth(string message)
        {
            
            Console.WriteLine(message);
        }
    }
}
