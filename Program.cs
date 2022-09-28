using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Değişkenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Değişkenler ile ilgili bilgiler.
            bool bo = true; //Bellekte 2 Byte yer kaplar, sadece true ve false değerlerini içerir.
            byte a = 0;     //Bellekte 1 Byte yer kaplar, 0 ile 255 arası tam sayı değerleri alabilir.
            decimal b = 3; //Bellekte 16 Byte yer kaplar, maksimum 29 haneli sayı tutar,Reel sayıları içerebilir.
            double d = -5,32; //Bellekte 8 Byte yer kaplar, negatif/pozitif Reel sayıları içerebilir.
            Int16 e = 5; //Bellekte 2 Byte yer kaplar.
            Int32 f = 5; //Bellekte 4 Byte yer kaplar.
            Int64 g = 5; //Bellekte 8 Byte yer kaplar.
            float h = 5; //Bellekte 4 Byte yer kaplar. Reel sayıları içerebilir.
            char c = "m";     //Bellekte 2 Byte yer kaplar, tek bir Unicode karakteri tutar.
            string i = "isim"; //Yazı karakterlerini tutar.
            DateTime dt = DateTime.Now; //Tarih ve saat için kullanılan kütüphane.

            //Değişken Kullanımı.
            int 1sayi = 1; //Değişken isimlerinden önce rakam kullanılamaz.
            int sayi1 = 1; //Değişken isimlerinden sonra sayıları kullanabilirsin.
            string ad soyad = "Cenker Sipahi"; //Değişken isimleri arası boşluk olmaz.
            string ad((soyad = "Cenker Sipahi"; //Değişkenler isimleri özel karakter içeremez.
            //Değişken tanımlarken mümkün olduğunca türkçe karakter kullanılmaz.
            int for = 4; //Değişken adları C# dilinde kullanılan kavramlardan oluşamaz. (for, if, while, else vb.)
            byte sayilar = 500; //Değişkenlere değerinden az veya fazla değer verilemez.

            //Ekrana yazdırma
            Console.WriteLine("Hello World!");
            Console.Write("Hello World!");//WriteLine ile Write arasındaki fark: WriteLine yazdıktan sonra bir sonraki satıra geçer.
            //Write ise yazdıktan sonra o satırda durur, daha çok klavyeden değer alırken bu şekilde kullanıyorum.

            //Klavyeden Veri alma
            Console.Write("Adınızı Giriniz : ");
            string name = Console.ReadLine();
            //Klavyeden alınan veriyi yazdırma,2 şekilde yapılabilir.
            //Birincisi.
            Console.WriteLine("Merhaba, {0}", name);
            //İkincisi.
            Console.WriteLine("Merhaba, " + name);

            //DateTime kullanımı
            DateTime st = DateTime.Now;
            Console.WriteLine("dd/MM/yyyy");//Çıktı olarak programı çalıştırdığınız tarihi gösterir.
            //dd gün için kullanılır.
            //MM ay için kullanılır, mm ise dakika için kullanılır.
            //yyyy yıl için kullanılır.


            //Object kullanımı.
            object c1 = "yazi";
            object c2 = 5;
            object c3 = 3.14;
            //Object her türlü değer alabilir; string, int, double vb. çünkü object bütün bu değişkenleri içinde kapsayan bir değişken.

            //Dönüşüm
            int sayi = 7;
            sayi = Convert.ToString(); //Burada int değerini string değerine çeviriyor, bunun gibi bir çok değeri de çevirmede kullanılabilir.
            Console.WriteLine(sayi);
        }
    }
}
