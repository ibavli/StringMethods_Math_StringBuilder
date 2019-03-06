using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = String.Empty;
            /*
           Trim Metodu Trim metodu string ifadede bulunan belli karakterleri baştan ve sondan silen metotdur. Trim metodu boşlukları temizleyebilir. Metot kullanımında dilersek kendi karakterlerimizi belirleyebiliriz. Verilen string ifadenin başında ve sonunda bulunan karakterleri temizlemek için kullanılır.
            */

            string BoslukOlanCumle = " bu cümlenin başında ve sonunda boşluk var ";
            Console.WriteLine(BoslukOlanCumle);
            Console.WriteLine("Baştan ve sondan sildi");
            Console.WriteLine(BoslukOlanCumle.Trim());

            Console.WriteLine("Sadece baştan sildi");
            Console.WriteLine(BoslukOlanCumle.TrimStart());

            Console.WriteLine("Sadece sondan sildi");
            Console.WriteLine(BoslukOlanCumle.TrimEnd());

            string cumle = "a!bcnx";
            Console.WriteLine(cumle.Trim('a', '!')); ; //cumle değişkeninde başta ve sonra bırakılan boşlukları temizler.Bu şekilde char dizisi tanımlanır ve bu yukarıda bulunan karakterlerin başta ve sonda olmasını engeller. Tek tırnak engellemek için başına \ ters slash kullanılarak yazılır. \' şeklinde tek tırnak engellenir.   


            /*
             Equals Metodu Eşitlik sorgulaması yapar verilen iki string ifadenin birbirine eşit olup olmadığını kontrol eder. Eşitlik durumu sonucunda boolean değer döner. Boolean değeri kullanarak bu metodu karar yapılarımız içinde kullanabiliriz. 
             */
            string isim1 = "ibrahim";
            string isim2 = "İBRAHİM";
            bool esitmi = isim1.Equals(isim2, StringComparison.CurrentCultureIgnoreCase);
            //StringComparison.OrdinalIgnoreCase : metotu kücük büyük harf gözetmeksizin karşılaştırma
            //StringComparison.CurrentCultureIgnoreCase : hem kücük büyük harf gözetmeksizin kıyaslama hemde dil seceneğine göre kıyaslama   
            Console.WriteLine(esitmi.ToString());



            /*
            SubString String ifadede bulunan karakterlerden belirtilen index numarasından başlayarak string ifadenin sonuna kadar keser. Örneğin ‘BilgeAdam’ ifadesinde sadece ‘Adam’ ifadesinin SubString’i ni almak istersek kullanabiliriz. 
             */

            string sonuc1 = isim1.Substring(2);
            Console.WriteLine(sonuc1); //indexi 2 olan harften başlayarak sonuna kadar kes, yani 0 ve 1 index numaraları karakterleri sil 3. harften başlayarak sonuna kadar al..   

            string sonuc2 = isim1.Substring(2, 4);//indexi 2 olan harften başlayarak 4 karakter al :)
            //Stringin boyutunu aşan bir substring işlemi yaparsak out of range hatası alırız. Bu hata string sınırlarını aşmak anlamına gelir. } 
            Console.WriteLine(sonuc2);
            Console.WriteLine();
            /*
             Reverse String ifadede ki karakter topluluğunu ters çevirmek için kullanılan string metotudur. 
             */

            var tersCevir = isim1.Reverse();
            foreach (var harf in tersCevir)
            {
                Console.WriteLine(harf);
            }

            /*
             Index Of Yazılan kelime içerisinde belirttiğim karakteri arar. Örneğin BilgeAdam string ifadesinde ‘a’ harfini aramak istediğimde kullanabilirim. Burada dikkat edilmesi gereken nokta, ilk ‘a’ harfini bulup indexini döndürür. Diğer a harflerini aramaz. Eğer string ifade içerisinde aradığımız karakter bulunamazsa index değeri olarak -1 döner. 
             */

            Console.WriteLine("r harfi : " + isim1.IndexOf('r').ToString()); //String ifade içerisinde r harfini arar. 
            Console.WriteLine("rah kelimesi : " + isim1.IndexOf('r').ToString()); //Şeklindede kullanılır. rah'ı arar
            Console.WriteLine("rah kelimesi : " + isim1.IndexOf('r', 1).ToString()); //1. indexten başlayarak bulmaya çalışır. Eğer hiç bir tanımlama vermezsek varsıylan olarak sıfır indexinden aramaya başlar. 
            Console.WriteLine();

            /*
             Remove String ifade içeriside belirttiğimiz alanı kesebilir ve kestiğimiz alan dışında kalan kısmı elde edebiliriz
             */

            Console.WriteLine(isim1.Remove(2, 4)); //2.index’den başla ve 4 karakter sil 

            /*
             Contains Contains metodu, metot içerisinde verilen ifadenin, string ifade içerisinde olup olmadığını kontrol eden string metotdur. Boolean sonuç döndürür. Eğer string ifade verdiğimiz değeri içeriyorsa true, içermiyorsa false değeri döndürür
             */
            bool iceriyormu = isim1.Contains('a');
            bool iceriyormu2 = isim1.Contains("rah");
            Console.WriteLine("iceriyormu : " + iceriyormu.ToString());
            Console.WriteLine("iceriyormu2 : " + iceriyormu2.ToString());
            Console.WriteLine();


            /*
             Replace String ifade içerisinde bulunan değerleri değiştirmek için kullanılır.  
             */
            string yenisim = isim1.Replace('i', 'x');
            Console.WriteLine(yenisim);
            string isimlicumle = "ibrahim bir isimdir";
            string yenisim2 = isimlicumle.Replace("ibrahim", "ibo");
            Console.WriteLine(yenisim2);
            Console.WriteLine();


            //Split metodu
            string seo = "erkek-gunluk-spor-ayakkabi";
            var ayirma = seo.Split('-');
            foreach (var kelime in ayirma)
            {
                Console.WriteLine(kelime);
            }
            Console.WriteLine();

            char[] ayiraclar = { '-', ' ' };
            string splitCumle = "erkek - gunluk - spor - ayakkabi";
            var yeniCumleSplit = splitCumle.Split(ayiraclar, StringSplitOptions.RemoveEmptyEntries);//Bunu yazmazsak boşlukları da aldı
            foreach (var item in yeniCumleSplit)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();


            //Join
            string[] kelimeler = { "erkek", "gunluk", "spor", "ayakkabi" };
            string yeniSeo = string.Join("-", kelimeler);
            Console.WriteLine("Yeni seo => " + yeniSeo);
            Console.WriteLine();


            //ToUpper ve ToLower
            string vs = "visual studio";
            string buyukHarfYap = vs.ToUpper();
            Console.WriteLine("ToUpper => " + buyukHarfYap);
            string buyukHarfYap2 = vs.ToUpperInvariant(); //İngilizce i ve I kuralına uygun olarak
            Console.WriteLine("ToUpperInvariant => " + buyukHarfYap2);
            string kucukHarfYap = buyukHarfYap2.ToLower();
            Console.WriteLine("ToLower => " + kucukHarfYap);
            string kucukHarfYap2 = buyukHarfYap2.ToLowerInvariant(); //İngilizce i ve I kuralına uygun olarak
            Console.WriteLine("ToLowerInvariant => " + kucukHarfYap2);
            Console.WriteLine("\n");

            string concatKelime1 = "ibrahim";
            string concatKelime2 = "bavlı";
            string concatHali = String.Concat(concatKelime1, " ", concatKelime2);
            Console.WriteLine("Concat işlemi => " + concatHali);


            string compare1 = "ibrahim123";
            string compare2 = "İBRAHİM123";
            var currentCulture = String.Compare(compare1, compare2, StringComparison.CurrentCulture); // Büyük küçük harf göz önünde bulundurulur
            var currentCultureIgnoreCase = String.Compare(compare1, compare2, StringComparison.CurrentCultureIgnoreCase); // Büyük küçük harf göz önünde bulundurulmaz
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            var invariantCultureIgnoreCase = String.Compare(compare1, compare2, StringComparison.InvariantCultureIgnoreCase); // İngilizcedeki i ve I ayrımı olmadan yaptık.
            Console.WriteLine();
            //Sonuç 0'dan küçükse compare1, compare2'den kısadır
            //Sonuç 0 ise eşittirler
            //Sonuç 0'dan büyükse compare1, compare2'den uzundur

            //PadRight ve PadLeft
            //15 karakter boyutuna ayarlar
            Console.Write("Adınız".PadRight(15, '.'));
            Console.WriteLine("ibrahim");
            Console.Write("Soyadınız".PadRight(15, '.'));
            Console.WriteLine("bavlı");




            Console.WriteLine();
            Console.WriteLine("Pad işlemleri");
            string foo = "Foo";
            string paddedLeft = foo.PadLeft(5);
            string paddedRight = foo.PadRight(6, '+');
            string noPadded = foo.PadLeft(2);

            Console.WriteLine(paddedLeft);
            Console.WriteLine(paddedRight);
            Console.WriteLine(noPadded);


            //Checking for empty String using String.IsNullOrEmpty() and String.IsNullOrWhiteSpace()
            string nullString = null;
            string emptyString = "";
            string whitespaceString = "    ";
            string tabString = "\t";
            string newlineString = "\n";
            string nonEmptyString = "abc123";

            bool result;
            result = String.IsNullOrEmpty(nullString);            // true
            result = String.IsNullOrEmpty(emptyString);           // true
            result = String.IsNullOrEmpty(whitespaceString);      // false
            result = String.IsNullOrEmpty(tabString);             // false
            result = String.IsNullOrEmpty(newlineString);         // false
            result = String.IsNullOrEmpty(nonEmptyString);        // false

            result = String.IsNullOrWhiteSpace(nullString);       // true
            result = String.IsNullOrWhiteSpace(emptyString);      // true
            result = String.IsNullOrWhiteSpace(tabString);        // true
            result = String.IsNullOrWhiteSpace(newlineString);    // true
            result = String.IsNullOrWhiteSpace(whitespaceString); // true
            result = String.IsNullOrWhiteSpace(nonEmptyString);   // false 


            int intValue = 10;
            string zeroPaddedInteger = intValue.ToString("000"); // Output will be "010"
            string customFormat = intValue.ToString("Input value is 0"); // output will be   "Input value is 10"

            double doubleValue = 10.456;
            string doubleroundedDouble = doubleValue.ToString("0.00"); // output 10.46
            string doubleintegerPart = doubleValue.ToString("00");    // output 10
            string doublecustomFormat = doubleValue.ToString("Input value is 0.0");  // Input value is 10.5

            // Determine whether a string begins with a given sequence
            string HelloWorld = "Hello World";
            HelloWorld.StartsWith("Hello"); // true
            HelloWorld.StartsWith("Foo"); // false


            string s = "Hello World";
            bool stringExists = s.Contains("ello");  //stringExists =true as the string contains the substring 

            //Joining an array of strings into a new one
            var parts = new[] { "Foo", "Bar", "Fizz", "Buzz" };
            var joined = string.Join(", ", parts);


            string s2 = "Hello World";
            s2 = s2.Replace("ell", String.Empty); // s = "Ho World" 


            string s3 = "My String";
            s3 = s3.ToLowerInvariant(); // "my string"
            s3 = s3.ToUpperInvariant(); // "MY STRING"

            Console.ReadLine();
        }
    }
}
