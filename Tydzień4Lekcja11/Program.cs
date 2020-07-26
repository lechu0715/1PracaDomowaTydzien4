using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tydzień4Lekcja11
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj liczbę");
                var number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine("liczba parzysta");
                }
                else
                {
                    Console.WriteLine("liczba nieparzysta");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Wprowadzone dane nie są liczbą");
                throw ex;
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
