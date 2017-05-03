using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Globalization;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //var link = new LinkedList<int>();
            //var j = link.AddFirst(1);
            //var str = new string('-', 100);
            //link.AddBefore(j, 2);
            //foreach (var y in link)
            //{
            //    Console.Write($"{y} ");
            //}
            //   Console.WriteLine(Avg(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ,11,15}));

            //    Console.ReadKey();
            //}
            //    public static double Avg(int[] arr)
            //{
            //    double avg = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        avg += arr[i];
            //    }
            //    return avg / arr.Length;
            //}

            //string s = "Egor";
            //string s1 = "Egor";
            //CompareInfo ci = CompareInfo.GetCompareInfo("en-AU");

            //var h = String.Intern(s);
            //var j = String.Intern(s1);
            //s.Equals(j, StringComparison.Ordinal);
            //Console.WriteLine(Object.ReferenceEquals(h,j));

            //var sb = new StringBuilder();
            //sb.AppendFormat(new BoldInt(), "Smth {0} has happened", 23);


            //var smthhere = new Smthhere();
            //smthhere.InicializationAndOperation();

            //var deepCopysmth = smthhere.Copy();
            //smthhere.Clear();
            //var arr = Array.CreateInstance(typeof(int), new int[] { 3, 3 }, new int[] { 4, 5 });
            //Console.WriteLine(sb);

            var c = new C();
            A a = c;

            a.Print2();
            a.Print1();
            c.Print2();





            Console.ReadKey();
        }
    }

    internal sealed class BoldInt : IFormatProvider, ICustomFormatter
    {
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            string s;
            IFormattable formattable = arg as IFormattable;
            if (formattable == null) s = arg.ToString();
            else s = formattable.ToString(format, formatProvider);
            if (arg.GetType() == typeof(Int32)) return $"<B>{s}</B>";
            return s;
        }

        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter)) return this;
            return System.Threading.Thread.CurrentThread.CurrentCulture.GetFormat(formatType);
        }
    }
}
