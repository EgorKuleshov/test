using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Diagnostics.Contracts;

namespace Smth2
{
    class Program
    {
        static void Main(string[] args)
        {
            RuntimeHelpers.PrepareConstrainedRegions();
            //string str = $"I did smth{Environment.NewLine}";
            //var smth = Encoding.UTF8.GetBytes(str);
            //var ds = new FileInfo(@"E:\Egggggggggg.txt");
            ////var filestream = new FileStream(@"E:\Eggggggg.txt", FileMode.OpenOrCreate);
            //if (ds.Exists)
            //{
            //    using (var filestream = new FileStream(ds.FullName, FileMode.Append))
            //    {
            //        filestream.Write(smth, 0, smth.Length);
            //            long g = filestream.Position;
            //    }

            //}
            //else
            //{
            //    using (var filestream = new FileStream(ds.FullName, FileMode.OpenOrCreate))
            //    {

            //    }
            //}
            
            try
            {
                Console.WriteLine("Block try");
                
                
            }
            //catch (OutOfMemoryException d)
            //{
            //    Console.WriteLine("Block catch");

            //}
            
            finally
            {
                Contract.Requires(false);

                Type.WriteSmth("Block finally");
                //filestream.Close();
            }
            Console.ReadKey();
        }
    }
    
}
