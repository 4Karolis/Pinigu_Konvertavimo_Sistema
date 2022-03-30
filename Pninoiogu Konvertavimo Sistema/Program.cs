using System;

namespace Pninoiogu_Konvertavimo_Sistema
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valiutos = {"USD", "PLN", "BYR" };
            //1 EUR = 1,1126 USD, 1 EUR = 4,6679 PLN, 1 EUR = 22288,8906 BYR
            decimal[] valiutuKursai = { 1,1126m, 4,6679m, 22288,8906m };

            Console.WriteLine("Ika noretumete komnvertuoti?");
            Console.WriteLine("[1] USD | [2] PLN | [3] BYR");
            int iKaKonvertuot = int.Parse(Console.ReadLine());
            switch (iKaKonvertuot)
            {
                case 1:
                    Console.WriteLine("Iveskite euru kieki: ");
                    decimal input1 = decimal.Parse(Console.ReadLine());
                    decimal UsdKiekis = valiutuKursai[0] * input1;
                    break;
                    //case 2:
                    Console.WriteLine("Iveskite euru kieki: ");
                    decimal input2 = decimal.Parse(Console.ReadLine());
                    decimal PlnKiekis = valiutuKursai[1] * input2;
                    break;
                case 3:
                    //Console.WriteLine("Iveskite euru kieki: ");
                    //int input1 = int.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Blogai ivestas pasirinkimas!");
                    break;
            }
        }
    }
}
