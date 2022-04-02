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
                        iseiti = false;
                        Console.Clear();
                        Console.WriteLine("Aciu, kad naudojates musu paslaugomis");
                        break;
                    case 4:
                        CloseApplication();
                        break;
                    //default:
                    //    Console.Clear();
                    //    Console.WriteLine("Blogai ivestas pasirinkimas! Rinkites dar karta");
                    //    break;
                }
            }
        }
        #region METODAI        
        private static void CloseApplication()
        {
            Console.WriteLine("Goodbey, thank you for using our Calculator");
            Console.WriteLine("Press any key to close application....");
            Environment.Exit(0);
        }
        public static decimal Keisai(decimal iKaonvertuot, decimal valiutuKursai, string valiutosSimbolis)
        {
            //int p = int.Parse(Console.ReadLine());
            string simbolis0 = valiutosSimbolis;
            decimal euruKiekis = IveskiteEuruKieki();
            decimal suma = Konverteris(euruKiekis, valiutuKursai, valiutosSimbolis);
            AnyKeyToContinue();
            return suma;
        }

        public static void AnyKeyToContinue()
        {
            Console.WriteLine("TESTI - Spauskite bet kuti kita mygtuka");
            if (!int.TryParse(Console.ReadLine(), out int exit)) ; Console.Clear();
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
            decimal iKaKonvertuot, input;
            while (true)
            {                
                decimal.TryParse(Console.ReadLine(), out decimal inputas);
                bool gerasInputas = inputas == 1 || inputas == 2 || inputas == 3 || inputas == 4;
                if (gerasInputas)
                {
                    iKaKonvertuot = inputas;
                    break;
                }
                //else if (gerasInputas)
                //{                    
                //    iKaKonvertuot = inputas;
                //    break;
                //}
                else
                {
                    Console.WriteLine("Bad input");
                    //Console.ReadLine();

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
