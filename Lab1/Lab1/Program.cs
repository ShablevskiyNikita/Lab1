using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void testAPlusBSquare<T>(T a, T b) where T : IMyNumber<T>
        {
            Console.WriteLine("=== Starting testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");
            T aPlusB = a.Add(b);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("(a + b) = " + aPlusB);
            Console.WriteLine("(a+b)^2 = " + aPlusB.Multiply(aPlusB));
            Console.WriteLine(" = = = ");
            T curr = a.Multiply(a);
            Console.WriteLine("a^2 = " + curr);
            T wholeRightPart = curr;
            curr = a.Multiply(b);
            curr = curr.Add(curr);
            Console.WriteLine("2*a*b = " + curr);
            wholeRightPart = wholeRightPart.Add(curr);
            curr = b.Multiply(b);
            Console.WriteLine("b^2 = " + curr);
            wholeRightPart = wholeRightPart.Add(curr);
            Console.WriteLine("a^2+2ab+b^2 = " + wholeRightPart);
            Console.WriteLine("=== Finishing testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");
        }

        static void testSquaresDifference<T>(T a, T b) where T : IMyNumber<T>
        {
            Console.WriteLine("=== Starting testing (a-b)=(a^2-b^2)/a+b with a = " + a + ", b = " + b + " ===");
            T aMinusB = a.Subtract(b);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("(a - b) = " + aMinusB);
            Console.WriteLine(" = = = ");
            T aInSquared = a.Multiply(a);
            Console.WriteLine("a^2 = " + aInSquared);
            T bInSquared = b.Multiply(b);
            Console.WriteLine("b^2 = " + bInSquared);
            T numerator = aInSquared.Subtract(bInSquared);
            Console.WriteLine("a^2 - b^2 = " + numerator);
            T denominator = a.Add(b);
            Console.WriteLine("a + b = " + denominator);
            Console.WriteLine("(a ^ 2 - b ^ 2)/(a + b) = " + numerator.Divide(denominator));
            Console.WriteLine("=== Finishing testing (a-b)=(a^2-b^2)/a+b with a = " + a + ", b = " + b + " ===");
        }

        static void Main(string[] args)
        {
            testAPlusBSquare(new MyFrac(1, 3), new MyFrac(1, 6));
            testAPlusBSquare(new MyComplex(1, 3), new MyComplex(1, 6));
            testSquaresDifference(new MyFrac(1, 3), new MyFrac(1, 6));
            testSquaresDifference(new MyComplex(1, 3), new MyComplex(1, 6));
            MyFrac[] Fracs = { new MyFrac(5615, 325), new MyFrac(34, 35),
                new MyFrac(13, 19), new MyFrac(45, 450),
                new MyFrac(5555523423423454, 4234234234243234234) };
            Array.Sort(Fracs);
            Console.WriteLine("\nSorted array of fractions: ");
            foreach (MyFrac elem in Fracs)
            {
                Console.Write(elem + " ");
            }
            Console.ReadKey();
        }
    }
}
