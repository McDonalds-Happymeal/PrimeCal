using System;
using  System.Linq;
using System.Diagnostics;

public class eratosthenes {
    public static void Main(string[]args) {

        Stopwatch stopWatch = new Stopwatch();
         int k =0;
         int c = 0;
        Console.WriteLine("this Program is designed to calculate primes; this program uses the sieve of eratosthenes algorithem.");
        Console.Write("\n\nPlease input a Integer that will be the highest number whis program will search to:");
        int max = Convert.ToInt32(Console.ReadLine());

        stopWatch.Start();
        bool[] x = Enumerable.Repeat(true, max).ToArray();

        for (int i = 2;i<=Math.Sqrt(max);i++) {
            k=2;
            while(k*i<max) {
                x[k*i] = false;
                 k++;

            }
        }

        k=0;
        foreach (bool z in x) {
            if (z) {
                Console.Write("{0},",k);
                c++;
            }
            k++;
        }

        stopWatch.Stop();

        Console.WriteLine("\n\nI got a total of {0} Primes in {1}",c,stopWatch.Elapsed);

    }
}