using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace New
{
    class Test
    {
        public void Print()
        {
            try
            {
                throw new Exception();
            }
            catch (Exception)
            {
                Console.Write("9");
                throw new Exception();
            }
            finally
            {
                Console.Write("2");
            }
        }
    }
        class Program
    {
        delegate void Mydel();
        static void Main(string[] args)
        {
            //var s1 = string.Format("{0}{1}", "abc", "cba");
            //var s2 = "abc" + "cba";
            //var s3 = "abccba";

            //Console.WriteLine(s1 == s2);
            //Console.WriteLine((object)s1 == (object)s2);
            //Console.WriteLine(s2 == s3);
            //Console.WriteLine((object)s2 == (object)s3);


            //var test = new Test();
            //try
            //{
            //    test.Print();
            //}
            //catch (Exception)
            //{
            //    Console.Write("5");
            //}
            //finally
            //{
            //    Console.Write("4");
            //}

            //var arr1 = new int[] { 1, 2, 3, 4, 5 };
            //var arr2 = new int[] { 2, 3, 4 };
            //for (int i = 0; i <arr2.Length; i++)
            //{
            //    arr1[i] += arr2[i];
            //}
            //foreach (var item in arr1)
            //{
            //    Console.Write($"{item} ");
            //}

            Mydel md = new Mydel(Console.WriteLine);
            var arr = new int[] { 1, 2, 3, 4 };
            //foreach (var i in arr)
            //{

            //    md += () => Console.WriteLine(i);
            //}
            for (int i = 0; i < arr.Length; i++)
            {
                md += () => Console.WriteLine(i);
            }
            md();
            Console.ReadKey();
        }
    
    }
}
