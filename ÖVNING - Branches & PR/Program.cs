namespace ÖVNING___Branches___PR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Initierar projekt");

            for (int i = 1; i <= 100; i++)
                
            {
                // om index är delbart med 3 och resten är = 0 skrivs siffran ut.
                //if (i % 3 == 0 && i % 5 == 0)
                //if (i % 15 == 0)
                //{
                //    Console.WriteLine(i + " FizzBuzz");
                //}
                //else if (i % 5 == 0)
                //{
                //    Console.WriteLine(i + " Buzz");
                //}
                //else if (i % 3 == 0)
                //{
                //    Console.WriteLine(i + " Fizz");
                //} 
                //else
                //{
                //    Console.WriteLine(i);
                //}

                if (i % 3 == 0 && i % 15 != 0)
                {
                    Console.WriteLine(i + " Fizz");
                }
                else if (i % 5 == 0 && i % 15 != 0)
                {
                    Console.WriteLine(i + " Buzz");
                }
                else if (i % 15 == 0)
                {
                    Console.WriteLine(i + " FizzBuzz");
                } 
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
