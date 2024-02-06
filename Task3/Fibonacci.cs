using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Fibonacci
    {
        public long FibonacciIterative(int n) //Time Complexity: O(n) - Each iteration of the loop takes constant time
                                                     //Space Complexity: O(1) - Constant space is used to store a few variables regardless of the input size
        {
            if (n <= 1)
                return n;

            long[] fib = new long[n + 1];
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            return fib[n];
        }
        public long FibonacciRecursive(int n) //Time Complexity: O(2^n) - The recursive approach has exponential time complexity
                                                        //because it recalculates Fibonacci numbers multiple times, leading to repeated work
                                                     //Space Complexity: O(n) - The recursive approach has linear space complexity due to the
                                                        //function call stack. In the worst case, the stack depth is proportional to the input n
        {
            if (n <= 1)
                return n;

            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        public long[] FibonacciIterativeArray(int n)
        {
            long[] result = new long[n];

            for (int i = 1; i < n; i++)
            {
                result[i] = FibonacciIterative(i);
            }

            return result;
        }

        public long[] FibonacciRecursiveArray(int n)
        {
            long[] result = new long[n];

            for (int i = 0; i < n; i++)
            {
                result[i] = FibonacciRecursive(i);
            }

            return result;
        }
    }
}