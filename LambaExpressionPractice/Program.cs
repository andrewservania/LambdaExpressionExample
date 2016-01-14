using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Andrew Servania
namespace LambaExpressionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeLambdaExpression();
        }


        /// <summary>
        /// A method showing a simple lambda expression with the use of a delegate (Func).
        /// Notice how the the Func delegate takes in a couple of strings and how the total length of the strings can be calculated.
        /// This is how the syntax of a lambda expression is along with the Func delegate.
        /// </summary>
        public static void SomeLambdaExpression()
        {
            // Notice how the last data type in the Func delegate is an int. The last datatype is the type of result one wishes
            // to output from the Func delegate. Think of the Func parameter list like this:
            // Func< input, input, input, input, input, input, output>
            Func<string, string, string, string, string, string, int> totalLength =
                (s1, s2, s3, s4, s5, s6) => s1.Length + s2.Length + s3.Length + s4.Length + s5.Length + s6.Length;

            int total = totalLength("hello", "world","oops","test","bleh","Oh!");

            Console.WriteLine("The total length of the words provided is: " + total);
            Console.ReadKey();
        }
    }
}
