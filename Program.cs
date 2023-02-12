using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genric
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
             int output = Number<int>.GetMaximum(32, 54, 5);
              Console.WriteLine($"max={output}");
             float output1 = Number<float>.GetMaximum(23.4f, 67.6f, 5.8f);
              Console.WriteLine($"max={output1}");
             string output2 = Number<string>.GetMaximum("jkl", "mkhdf", "the");
              Console.WriteLine($"max={output2}");

            
        }
    }
}
