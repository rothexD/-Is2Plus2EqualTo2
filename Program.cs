using System;

namespace Is2Plus2Equal4
{
    public static class Example
    {
        public static bool Is2Plus2Equal4Method()
        {
            if (2 + 2 == 4)
            {
                return true;
            }
            return false;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            if (Example.Is2Plus2Equal4Method())
            {
                Console.WriteLine("Yes 2 plus 2 is 4");
            }
            else
            {
                Console.WriteLine("No 2 plus 2 is not 4");
            }
        }
    }
}
