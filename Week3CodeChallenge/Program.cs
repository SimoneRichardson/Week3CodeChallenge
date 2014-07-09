using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //a function that takes a number parameter and loops through numbers and finds 
            //as many prime numbers as indicated by the parameter
            FindPrimes(100001);

            //call for the function to print out the 1001st ptime number
            Console.WriteLine();
            //Function call for EvenFibonacciSequencer parameter 1000000
            EvenFibonacciSequencer(1000000);
            //print to console
            Console.WriteLine();
            //Function call for LongestCollatzSequencer
            LongestCollatzSequence(837799);
            //print to console
            Console.WriteLine();

            Console.ReadKey();
        }

        static void FindPrimes(int maxPrime)
        {
        //declare list to store prime numbers
            List<int> primeList = new List<int>(){2};
        //loops until it finds as many prime numbers
            int test = 3;
            while (primeList.Count < maxPrime)
           {
            //While isPrime is true it will run for Loop
                bool isPrime = true;
                for (int i = 2; i < test; i++) 
                {
                //if the test number is divisible by 2
                    if (test % i == 0) 
                    {
                    //if false will stop running and break loop
                        isPrime = false;
                        break;
                    }
                }
                // if the number is prime
                if (isPrime == true) 
                {
                // add number to created list
                    primeList.Add(test);
                }
           // test numbers go up by one
                test++;
            }
           //Prints to console what 100001st number is
            //prime number is
            Console.WriteLine("The 100001st prime number is: " + primeList.Last());
            {
                     
            
            //EvenFibonnacciSequencer Function
            static void EvenFibonacciSequencer(int maxValue)
            {
                //create a list to hold numbers in fibonaccisequencer
                List<int> fibSeq = new List<int>{1,2};
            //start sequence with 2
            int total = 2;
            //create loop to run through numbers
            //add to previous numbers
            for (int i = 0; i < maxValue; i++)
            {
            //integers that need to be added together
            //and add to the list
            int first = fibSeq[i];
            int last  = fibSeq[i + 1];
            int final = first + last;

            //adding a number to list
            fibSeq.Add(final);

            //if the final result of the two numbers
            //is even it will get added with our total
            if (final % 2 ==0)
            {
              total += final;
            }
            }
            //Print to console
            Console.WriteLine("Fibonacci Sequence: " + total);
            }
        //Function for LongestCollatzSequence
        static void LongestCollatzSequence(long input)
        {
        long n = input;
        long loopCount = 0;
        //while n is greater than 1
            while( n > 1)
            {
            //if n is even by 2 then 
            //n will be divided by 2 and increase loop by 1
                if (n % 2 == 0)
                {
                n = n / 2;
                    loopCount++;
                }
            //if n is odd it will be multiplied by 3
            //and the result will be added by 1. The loop
            //count will increase by 1
            else
                {
                n = 3 * n + 1;
                    loopCount++;
                }
            }
        
            Console.WriteLine("Input: " + input);
            //Prints to the console what the Loop count is for the number inputed
            Console.WriteLine("The loop count is: " +(loopCount + 1));
	   }
    
    }
}
