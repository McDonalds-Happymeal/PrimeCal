using System;
using System.Diagnostics;

public class Prime
{
    public static void Main(string[]args)
    {
        Stopwatch stopWatch = new Stopwatch();
        bool isPrime=false;
        int x = 0;
        int total =0;

        Console.WriteLine("this Program is designed to calculate primes; this is not the best or correct way to do this and at the moment just brute forces calculation");
        Console.Write("\n\nPlease input a Integer that will be the highest number whis program will search to:");
        int max = Convert.ToInt32(Console.ReadLine());

        stopWatch.Start();

        for (int i = 1;i<max;i++)
        {
                isPrime=true;
                x = i;
                while (x!=1 && isPrime)
                {
                    if (i%x==0&&x!=1&&i!=x){
                        isPrime=false;
                        //Console.WriteLine("{0} % {1} = {2}",i,x,i%x);
                    }
                    x--;
                }
                if(isPrime){
                    total++;
                    Console.Write("{0},",i);
                }
        }
        stopWatch.Stop();

        Console.WriteLine("\n\nI got a total of {0} Primes in {1}",total,stopWatch.Elapsed);

    }
}