using System;

namespace _5
{
    class Program
    {
        static void Main()
        {
            Console.Write("mojodi:");
            string a = Console.ReadLine();
            int x = Convert.ToInt32(a);
            Console.Write("darsad bahre:");
            string b = Console.ReadLine();
            double y = Convert.ToDouble(b);
            Console.Write("mojodi jadid:");
            string c = Console.ReadLine();
            int z = Convert.ToInt32(c);
            Console.Write("entehaye sal:");
            Console.WriteLine(javab(x, y, z));
        }//end main
        private static int javab(int x,double y,int z)
        {
            double a = 0;
            int b = 0;
            for(int i = 1; x < z; i++)
            {
                a = x * (y / 100);
                x = (int)(x + a);
                b = i;
            }
            return b;
        }
    }
}
