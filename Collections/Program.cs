using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"taha","engin","ayşe" };
            //Console.WriteLine(isimler[0]);
            //isimler = new string[3];
            //isimler[3] = "mehmet";

            List<string> isimler2 = new List<string>
                { "taha", "engin", "ayşe"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("ilker");
            Console.WriteLine( "-----------------");
            Console.WriteLine(  isimler2[3]);
            Console.WriteLine(isimler2[0]);


        }
    }
}
