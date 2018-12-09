using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            // MATH
            Console.WriteLine("Pi sayısı : " + Math.PI);
            Console.WriteLine("25.4 üste yuvarladık : " + Math.Ceiling(25.4)); //Çıktı 26
            Console.WriteLine("25.4 alta yuvarladık : " + Math.Floor(25.4)); // Çıktı 25
            Console.WriteLine("İki sayıdan max olanı : " + Math.Max(25, 12));
            Console.WriteLine("İki sayıdan min olanı : " + Math.Min(25, 12));
            Console.WriteLine("Üçün karesi : " + Math.Pow(3, 2)); //Çıktı 9
            Console.WriteLine("16'nın karekökü : " + Math.Sqrt(16));
            //Math.Round => Parametre olarak verilen sayının, virgülden sonraki değerine göre yukarı veya aşağı yuvarlanmasını sağlar. 
            Console.WriteLine(Math.Round(4.2m)); //Çıktı : 4
            Console.WriteLine(Math.Round(4.7m)); //Çıktı : 5 


            Kontrol(-14);
            Kontrol(78);
            Kontrol(0);


            Console.Read();
        }

        public static void Kontrol(int sayi)
        {
            var sonuc = Math.Sign(sayi);
            switch (sonuc)
            {
                case -1:
                    Console.WriteLine("Sayı negatif");
                    break;
                case 0:
                    Console.WriteLine("Sayı sıfır");
                    break;
                case 1:
                    Console.WriteLine("Sayı pozitif");
                    break;
            }
        }
    }
}
