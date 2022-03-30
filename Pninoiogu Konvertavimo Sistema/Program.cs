using System;

namespace Pninoiogu_Konvertavimo_Sistema
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valiutos = { "USD", "PLN", "BYR" };
            //1 EUR = 1,1126 USD, 1 EUR = 4,6679 PLN, 1 EUR = 22288,8906 BYR pagal 22.03.30 duomenis
            decimal[] valiutuKursai = { 1.1126m, 4.6679m, 22288.8906m };

            //IKaKonvertuoti();
            //Console.WriteLine("I ka noretumete komnvertuoti?");
            //Console.WriteLine("[1] USD | [2] PLN | [3] BYR");
            //int iKaKonvertuot = int.Parse(Console.ReadLine());
            decimal iKaKonvertuot = IKaKonvertuoti();
            switch (iKaKonvertuot)
            {
                case 1:
                    decimal euruKiekis = IveskiteEuruKieki();
                    decimal suma = Konverteris(euruKiekis, valiutuKursai: (decimal)valiutuKursai[iKaKonvertuot]);
                   // decimal usdKiekis = valiutuKursai * euruKiekis;
                    //Console.WriteLine($"Jums priklauso: {usdKiekis} {valiutos[0]}");
                    break;
                case 2:
                    Console.WriteLine("Iveskite euru kieki: ");
                    decimal input2 = decimal.Parse(Console.ReadLine());
                    decimal plnKiekis = valiutuKursai[1] * input2;
                    Console.WriteLine($"Jums priklauso: {plnKiekis} {valiutos[1]}");
                    break;
                case 3:
                    Console.WriteLine("Iveskite euru kieki: ");
                    decimal input3 = decimal.Parse(Console.ReadLine());
                    decimal byrKiekis = valiutuKursai[2] * input3;
                    Console.WriteLine($"Jums priklauso: {byrKiekis} {valiutos[2]}");
                    break;
                default:
                    Console.WriteLine("Blogai ivestas pasirinkimas!");
                    break;
            }
            #region
            //Console.WriteLine("I ka noretumete komnvertuoti?");
            //Console.WriteLine("[1] USD | [2] PLN | [3] BYR");
            //int iKaKonvertuot = int.Parse(Console.ReadLine());
            //switch (iKaKonvertuot)
            //{
            //    case 1:
            //        Console.WriteLine("Iveskite euru kieki: ");
            //        decimal input1 = decimal.Parse(Console.ReadLine());
            //        decimal usdKiekis = valiutuKursai[0] * input1;
            //        Console.WriteLine($"Jums priklauso: {usdKiekis} {valiutos[0]}");
            //        break;
            //    case 2:
            //        Console.WriteLine("Iveskite euru kieki: ");
            //        decimal input2 = decimal.Parse(Console.ReadLine());
            //        decimal plnKiekis = valiutuKursai[1] * input2;
            //        Console.WriteLine($"Jums priklauso: {plnKiekis} {valiutos[1]}");
            //        break;
            //    case 3:
            //        Console.WriteLine("Iveskite euru kieki: ");
            //        decimal input3 = decimal.Parse(Console.ReadLine());
            //        decimal byrKiekis = valiutuKursai[2] * input3;
            //        Console.WriteLine($"Jums priklauso: {byrKiekis} {valiutos[2]}");
            //        break;
            //    default:
            //        Console.WriteLine("Blogai ivestas pasirinkimas!");
            //        break;
            //}
            #endregion
        }
        //public static void JumsPriklauso(decimal input, string[] valiuta, decimal[] kursas)
        //{
        //    input = IveskiteEuruKieki();
        //    valiuta = string[] valiutos();
        //}
        //public static void JumsPriklauso(decimal kiekis, decimal[] kursas, string[] simbolis)
        //{ 
        //    Console.WriteLine($"Jums priklauso: {kiekis * kursas[]} {}");
        //}
        public static decimal Konverteris(decimal euruKiekis, decimal valiutuKursai, string valiutos)
        {
            euruKiekis = IveskiteEuruKieki();
            decimal suma = euruKiekis * valiutuKursai;
            //decimal priklauso = 
            return (Console.WriteLine($"Jums priklauso: {suma} {valiutos}")); 
        }
        public static decimal IveskiteEuruKieki()
        {
            Console.WriteLine("Iveskite euru kieki: ");
            decimal euruKiekis = decimal.Parse(Console.ReadLine());
            return euruKiekis;
        }
        public static decimal IKaKonvertuoti()
        {
            Console.WriteLine("I ka noretumete komnvertuoti?");
            Console.WriteLine("[0] USD | [1] PLN | [2] BYR");
            decimal iKaKonvertuot = decimal.Parse(Console.ReadLine());
            return iKaKonvertuot;
        }
    }
}
