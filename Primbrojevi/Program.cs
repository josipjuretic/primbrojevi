using System;

namespace Vsite.Pood
{
    public class Program
    {
        static void Main(string[] args)
        {
            IspišiPrimbrojeve(0);
            Console.ReadKey();
            IspišiPrimbrojeve(1);
            Console.ReadKey();
            IspišiPrimbrojeve(2);
            Console.ReadKey();
            IspišiPrimbrojeve(100);
            Console.ReadKey();
        }

        static void IspišiPrimbrojeve(int max)
        {
            Console.WriteLine("Primbrojevi do {0}:", max);
            var brojevi = GenerirajPrimBrojeve(max);
            if (brojevi.Length == 0)
                Console.WriteLine("Nema");
            else
            {
                foreach (var broj in brojevi)
                    Console.WriteLine(broj);
            }
        }

        static bool[] f;

        // Primjer iz knjige  Robert C. Martin: "Agile Software Development"!!!
        public static int[] GenerirajPrimBrojeve(int max)
        {
            if (max < 2)
                return new int[0];
            InicijalizirajSito(max);
            Prosijaj();
            return IzdvojiPrimBrojeve(max);
        }

        private static int[] IzdvojiPrimBrojeve(int max)
        {
            int broj = 0;
            for (int i = 2; i < f.Length; ++i)
            {
                if (f[i])
                    ++broj;
            }

            int[] primovi = new int[broj];

            // prebaci primbrojeve u rezultat
            for (int i = 0, j = 0; i < f.Length; ++i)
            {
                if (f[i])
                    primovi[j++] = i;
            }
            return primovi; // vrati niz brojeva
        }

        private static void Prosijaj()
        {
            for (int i = 2; i < Math.Sqrt(f.Length); ++i)
            {
                if (f[i]) // ako je i prekrižen, prekriži i višekratnike
                {
                    EliminirajViešekratnike(i);
                }
            }

        }

        private static void EliminirajViešekratnike(int i)
        {
            for (int j = 2 * i; j < f.Length; j += i)
                f[j] = false; // višekratnik nije primbroj
        }

        private static void InicijalizirajSito(int max)
        {
            f = new bool[max + 1]; // niz s primbrojevima

            // inicijaliziramo sve na true
            for (int i = 2; i < f.Length; ++i)
                f[i] = true;
        }
    }
}
