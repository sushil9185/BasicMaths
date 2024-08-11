using System.Diagnostics.CodeAnalysis;

namespace BasicMaths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(CountDigits1(5));
            //Console.WriteLine(CountDigits2(2));
            //Console.WriteLine(CountDigits3(458765432));
            //Console.WriteLine(ReverseNumber(1331));
            //Console.WriteLine(CheckPalindrome(121));
            //Console.WriteLine(CheckArmstrongNumber(1634));
            //PrintAllDivisors1(36);
            //PrintAllDivisors2(42);
            //Console.WriteLine(CheckPrimeNumber1(17));
            //Console.WriteLine(CheckPrimeNumber2(17));
            //PrintGCD1(90, 40);
            //PrintGCD2(90, 40);
            //PrintGCD3(52, 2);

        }

        static void PrintGCD3(int n1, int n2)
        {
            while ( n1 > 0 &&  n2 > 0 )
            {
                if( n1 > n2)
                    n1 = n1 % n2;
                else 
                    n2 = n2 % n1;
            }
            if (n1 == 0) Console.WriteLine(n2);
            else Console.WriteLine(n1);
        }

        static void PrintGCD2(int n1, int n2)
        {
            int gcd = 1;
            int min = Math.Min(n1, n2);
            for(int i = min; i >0; i--)
            {
                if(n1 % i == 0 && n2 % i == 0)
                {
                    gcd = i; break;
                }
            }
            Console.WriteLine(gcd);
        }

        static void PrintGCD1(int n1, int n2)
        {
            int gcd = 1;
            int min = Math.Min(n1, n2);
            for(int i = 1; i <= min; i++)
            {
                if(n1 % i == 0 && n2 % i == 0)
                {
                    gcd = i;
                }
            }
            Console.WriteLine(gcd);
        }

        static bool CheckPrimeNumber2(int n)
        {
            int count = 0;
            for(int i = 1; i*i <= n; i++)
            {
                if(n % i == 0)
                {
                    count++;
                    if(n/i != i)
                        count++;
                }
            }

            if(count == 2) return true;

            return false;
        }

        static bool CheckPrimeNumber1(int n)
        {
            int count = 0;
            for(int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    count++;  
            }

            if(count == 2)
                return true;
            else
                return false;
        }

        //Print all Divisors of a given Number - Brute Force Method
        static void PrintAllDivisors1(int n)
        {
            for(int i = 1; i <= n; i++) 
            { 
                if(n % i == 0)
                    Console.Write(i + " ");
            }
        }

        static void PrintAllDivisors2(int n)
        {
            List<int> divisors = new List<int>();

            for(int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    divisors.Add(i);
                    if (i != n / i) divisors.Add(n/i);
                }
            }

            divisors.Sort();

            for (int i = 0; i < divisors.Count; i++)
            {
                Console.Write(divisors[i] + " ");
            }
        }


        //Armsstrong Number eg n = 371 3^3 + 7^3 + 1^3 = 371 then Armstrong Number
        static bool CheckArmstrongNumber(int n)
        {
            int count, sum;
            count = sum = 0;
            int orgN, countN;
            orgN = countN = n;
            //count number of digits
            while (countN > 0)
            {
                count++;
                countN = countN / 10;
            }

            //Calculate Sum
            while (n > 0)
            {
                int lastDigit = n % 10;
                sum = sum + (int)Math.Pow(lastDigit,count);
                n = n / 10;
            }

            if(orgN == sum) { return true; }

            return false;
        }



        //Palindrome Number eg n = 121 reverse is also 121 so Palindrome number.
        static bool CheckPalindrome(int n)
        {
            int orgN = n;
            int lastDigit, revNumber = 0;
            while(n > 0)
            {
                lastDigit = n % 10;
                revNumber = 10 * revNumber + lastDigit;
                n = n / 10;
            }

            if(orgN == revNumber) { return true; }
            else { return false; }
        }


        //Reverse a Number
        static int ReverseNumber(int n)
        {
            int revNumber = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                revNumber = revNumber * 10 + lastDigit;
                n = n / 10;
            }
            return revNumber;
        }

        //Count digits in a number
        static int CountDigits1(int n)
        {
            if(n == 0) return 1;

            n = Math.Abs(n);
            int count = 0;
            while(n > 0)
            {
                count++;
                n = n /10;
            }
            return count;
        }

        //Count digits in a number
        static int CountDigits2(int n)
        {
            string s = n.ToString();
            return s.Length;
        }

        //Count digits in a number
        static int CountDigits3(int n)
        {
            return (int)Math.Floor(Math.Log10(n) + 1);
        }
    }
}