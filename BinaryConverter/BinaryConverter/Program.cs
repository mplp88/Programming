using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            string exit = "";
            bool cont = true;
            BitArray bitArr;
            do
            {
                Console.Write("Enter number or type 'quit' to exit: ");
                exit = Console.ReadLine();
                if (exit.Trim().ToLower() != "exit" && exit.Trim().ToLower() != "quit")
                {
                    if (int.TryParse(exit, out n))
                    {
                        try
                        {
                            bitArr = new BitArray(n);
                            Console.WriteLine(bitArr.PrintBitArray(n));
                        }
                        catch(Exception)
                        {
                            Console.WriteLine("Number Out of Bounds, max is 65535");
                        }
                    }
                }
                else
                {
                    cont = false;
                }
            } while (cont);
        }
    }
}
