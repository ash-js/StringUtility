
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence =
                "This is going to be a really really really really really really really really really really really really long text";
            var summery = StringUtility.SummerizeText(sentence, 25);
            Console.WriteLine(summery);
        }

        
    }
}
 