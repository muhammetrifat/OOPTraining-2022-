using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] {"Muhammed", "İbrahim", "Ahmed", "Mahmud" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            Console.WriteLine("------------------------------------------------");

            List<string> isimler2 = new List<string>() { "Muhammed", "İbrahim", "Ahmed", "Mahmud" };
            isimler2.Add("Saliha");
            Console.WriteLine(isimler2[4]);
        }
    }
}
