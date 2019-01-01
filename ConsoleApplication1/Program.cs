using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {





        static int RodCutting(int[] prices, int N)
        {
            int[] Value = new int[N + 1];
            Value[0] = 0;

            //O(N^2) solution
            for (int i = 1; i <= N; i++)
            {
                int max_value = int.MinValue;

                for (int j = 0; j < i; j++)
                {
                    max_value = Math.Max(max_value, prices[j] + Value[i - j - 1]);
                }
                Value[i] = max_value;
            }

            return Value[N];
        }
       
        
        
      
        static void Main(string[] args)
        {
            int[] prices = { 1, 5, 8, 9, 10 };
            // price of 4 uncut is 9 
            // when 4 is cut to 2 & 2 now price will go up
            int Result = RodCutting(prices , 4);
            Console.WriteLine(Result);
           
        }
    }
}
