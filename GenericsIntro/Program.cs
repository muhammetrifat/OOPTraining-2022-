using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string, int, bool> isimler = new MyList<string, int, bool>();
            isimler.Add("Muhammed", 1997, true);
            Console.WriteLine(isimler.Item1[0]);

            isimler.Add("Saliha", 1995, false);
            Console.WriteLine(isimler.Item2[1]);
        }
    }
}
