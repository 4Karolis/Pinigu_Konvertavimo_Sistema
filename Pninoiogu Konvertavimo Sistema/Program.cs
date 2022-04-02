using System;

namespace Pninoiogu_Konvertavimo_Sistema
{
    class Program
    {
        #region PROGRAMA
        static void Main(string[] args)
        {
            bool iseiti = true;
            while (iseiti)
            {
                string[] valiutosSimbolis = { "USD", "PLN", "BYR" };          // 1 EUR = 1,1126 USD, 1 EUR = 4,6679 PLN, 
                decimal[] valiutuKursai = { 1.1126m, 4.6679m, 22288.8906m };  // 1 EUR = 22288,8906 BYR pagal 22.03.30 duomenis

                Meniu();
                decimal iKaKonvertuot = IKaKonvertuoti();
                switch (iKaKonvertuot)
                {
                    case 0:
                        Keisai(iKaKonvertuot, valiutuKursai[0], valiutosSimbolis[0]);
                        break;
                    case 1:
                        Keisai(iKaKonvertuot, valiutuKursai[1], valiutosSimbolis[1]);
                        break;
                    case 2:
                        Keisai(iKaKonvertuot, valiutuKursai[2], valiutosSimbolis[2]);
                        break;
                    case 3:                        
                        Dasviduli();
                        break;                    
                }
            }
        }
        #endregion

        #region METODAI             
        
        public static bool Iseiti(bool iseiti)
        {
            iseiti = false;
            Console.Clear();
            Console.WriteLine("Aciu, kad naudojates musu paslaugomis. Iki kito karto!");
            return iseiti;
        }
        private static void Dasviduli()
        {
            Console.Clear();
            Console.WriteLine("Aciu, kad naudojates musu paslaugomis. iki kito karto!");
            Environment.Exit(0);
        }
        public static decimal Keisai(decimal iKaKonvertuot, decimal valiutuKursai, string valiutosSimbolis)
        {
            Console.Clear();
            string simbolis = valiutosSimbolis;
            decimal euruKiekis = IveskiteEuruKieki();
            decimal suma = Konverteris(euruKiekis, valiutuKursai, valiutosSimbolis);
            AnyKeyToContinue();
            return suma;
        }
        public static void AnyKeyToContinue()
        {
            Console.WriteLine("\n        [TESTI] - Spauskite bet kuti mygtuka");
            if (!int.TryParse(Console.ReadLine(), out int exit)) ; Console.Clear();
        }
        public static decimal Konverteris(decimal euruKiekis, decimal valiutuKursai, string valiutosSimbolis)
        {
            Console.Clear();
            string y = valiutosSimbolis;
            decimal suma = euruKiekis * valiutuKursai;
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("-------------- KONVERTAVIMO REZULTATAI --------------");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"\n          Jums priklauso: {suma} {y}");
            return suma;
        }
        public static decimal IveskiteEuruKieki()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("-------------------- IVEDIMO MENIU ------------------");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("                  Iveskite euru kieki: ");

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
            decimal iKaKonvertuot;
            while (true)
            {                
                decimal.TryParse(Console.ReadLine(), out decimal inputas);
                bool gerasInputas = inputas == 1 || inputas == 2 || inputas == 3;
                if (gerasInputas)
                {
                    iKaKonvertuot = inputas;
                    break;
                }                
                else
                {
                    Console.WriteLine("Bad input");
                }                
            }
            return iKaKonvertuot;
        }
        public static void Meniu()
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("------------ PROGRAMA KONVERTUOJA EURUS -------------");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("           I ka noretumete komnvertuoti?");
            Console.WriteLine("\n[0] USD | [1] PLN | [2] BYR | [3] ISEITI is programos");
        }
        #endregion
    }
}
