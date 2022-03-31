using System;

namespace Pninoiogu_Konvertavimo_Sistema
{
    class Program
    {
        static void Main(string[] args)
        {
            bool iseiti = true;
            while (iseiti)//pabandyt su try.parse
            {
                string[] valiutosSimbolis = { "USD", "PLN", "BYR" };
                //1 EUR = 1,1126 USD, 1 EUR = 4,6679 PLN, 1 EUR = 22288,8906 BYR pagal 22.03.30 duomenis
                decimal[] valiutuKursai = { 1.1126m, 4.6679m, 22288.8906m };

                decimal iKaKonvertuot = IKaKonvertuoti();
                switch (iKaKonvertuot)
                {
                    case 0:
                        //int p = int.Parse(iKaKonvertuot);
                        //Belekas(iKaKonvertuot, valiutosSimbolis[p], valiutuKursai[p]);
                        string simbolis0 = valiutosSimbolis[0];
                        decimal euruKiekis = IveskiteEuruKieki();
                        decimal suma = Konverteris(euruKiekis, valiutuKursai[0], valiutosSimbolis[0]);
                        AnyKeyToContinue();
                        break;
                    case 1:
                        string simbolis1 = valiutosSimbolis[1];
                        decimal euruKiekis1 = IveskiteEuruKieki();
                        decimal suma1 = Konverteris(euruKiekis1, valiutuKursai[1], valiutosSimbolis[1]);
                        AnyKeyToContinue();
                        break;
                    case 2:
                        string simbolis2 = valiutosSimbolis[2];
                        decimal euruKiekis2 = IveskiteEuruKieki();
                        decimal suma2 = Konverteris(euruKiekis2, valiutuKursai[2], valiutosSimbolis[2]);
                        AnyKeyToContinue();
                        break;
                    case 3:
                        iseiti = false;
                        Console.Clear();
                        Console.WriteLine("Aciu, kad naudojates musu paslaugomis");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Blogai ivestas pasirinkimas! Rinkites dar karta");
                        break;
                }
            }
        }
        #region METODAI        
        //public static decimal Belekas(decimal p, string valiutosSimbolis, decimal valiutuKursai)
        //{
        //    p = IKaKonvertuoti();
        //    string simbolis = valiutosSimbolis;
        //    decimal euruKiekis = IveskiteEuruKieki();
        //    decimal suma = Konverteris(euruKiekis, valiutuKursai, valiutosSimbolis);
        //    AnyKeyToContinue();
        //    return suma;
        //}
        public static void AnyKeyToContinue()
        {
            Console.WriteLine("TESTI - Spauskite bet kuti kita mygtuka");            
            if (!int.TryParse(Console.ReadLine(), out int exit)); Console.Clear();
        }
        public static decimal Konverteris(decimal euruKiekis, decimal valiutuKursai, string valiutosSimbolis)
        {            
            string y = valiutosSimbolis; 
            decimal suma = euruKiekis * valiutuKursai;
            Console.WriteLine($"Jums priklauso: {suma} {y}");
            //AnyKeyToContinue();
            return suma; 
        }
        public static decimal IveskiteEuruKieki()
        {
            Console.WriteLine("Iveskite euru kieki: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal euruKiekis))
            {
                return euruKiekis;
            }
            else
            {
                Console.WriteLine("Blogai ivestas pasirinkimas!");
                return IveskiteEuruKieki(); 
            }
        }
        public static decimal IKaKonvertuoti()
        {            
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("------------ PROGRAMA KONVERTUOJA EURUS -------------");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("           I ka noretumete komnvertuoti?");
            Console.WriteLine("\n[0] USD | [1] PLN | [2] BYR | [3] ISEITI is programos");
            if (decimal.TryParse(Console.ReadLine(), out decimal iKaKonvertuot))
            {
                return iKaKonvertuot;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Blogai ivestas pasirinkimas! Rinkites dar karta");
                return IKaKonvertuoti();                
            }            
        }
        #endregion
    }
}
