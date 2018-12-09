using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderEx
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();

            //Alt satıra geçmeden ekleme yaptı
            stringBuilder.Append("isim ");
            stringBuilder.Append("ve ");
            stringBuilder.Append("soyisimler");

            //Alt satıra geçerek ekleme yaptı
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("-----------");
            stringBuilder.AppendLine();

            stringBuilder.AppendLine("ali veli");
            stringBuilder.AppendLine("hasan hüseyin");
            stringBuilder.AppendLine("ahmet mehmet");
            stringBuilder.AppendLine("hatica fadime");

            Console.WriteLine(stringBuilder.ToString());



            StringBuilder stringBuilder2 = new StringBuilder();

            //AppendFormat
            stringBuilder2.AppendFormat("{0:hh:mm:ss}", DateTime.Now);
            stringBuilder2.AppendLine();
            stringBuilder2.AppendFormat("{0:HH:mm:ss}", DateTime.Now);
            stringBuilder2.AppendLine();
            stringBuilder2.AppendFormat("{0:dd MM yyyy}", DateTime.Now);
            stringBuilder2.AppendLine();
            stringBuilder2.AppendFormat("{0:dd MMMM yyyy}", DateTime.Now);
            stringBuilder2.AppendLine();
            stringBuilder2.AppendFormat("{0:dd MMMM yyyy HH:mm:ss}", DateTime.Now);

            Console.WriteLine(stringBuilder2.ToString());
            Console.ReadLine();
        }
    }
}
