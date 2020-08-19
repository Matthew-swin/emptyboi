using System;

namespace pickme
{
    class Program
    {
        static void Main(string[] args)
        {
           int celcius = 11;
            double f =  (celcius * 9d) / 5d + 32d;
            //figuring out floor,ceiling and round #alexIsADick
                        if (f < 0)
              {
              int fah = (int)Math.Floor(f);
               
              }
            int fahrenheit = (int)(Math.Ceiling(f));

            System.Console.WriteLine(f);
            System.Console.WriteLine(fahrenheit);
        }
    }
}
