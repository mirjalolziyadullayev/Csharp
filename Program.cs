using System;

namespace Csharp_syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = -1;

            if (number == 0) {
                Console.WriteLine("0 musbatham manfiyham emas");
            } else if (number < 0) {
                Console.WriteLine("manfiy son");
            } else
            {
                Console.WriteLine("musbat son");
            }
        }
    }
}
