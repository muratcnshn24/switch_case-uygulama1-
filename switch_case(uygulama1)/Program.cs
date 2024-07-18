using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_uygulama1_
{
    class Program
    {
        public enum Renkler {Kirimizi, Yesil, Mavi} // değer vermezsek numaralandırmaya sıfırdan başlarlar.

        static void Main(string[] args)
        {
            Renkler r = (Renkler)(new Random()).Next(0,3);

            switch (r)  // r yazdığımda switch case otomatik olara buraya yazılıyor.
            {
                case Renkler.Kirimizi:
                    Console.WriteLine(" Renk Kirmizidir");
                    break;
                case Renkler.Yesil:
                    Console.WriteLine(" Renk Yeşildir");
                    break; // bütün komutları bir birinde nayırmak için break komutu zorunlu
                case Renkler.Mavi:
                    Console.WriteLine(" Renk Mavidir");
                    break;
                default:
                    Console.WriteLine(" Renk Bilinmiyor");
                    break;
            }
        }


 
    }
}
