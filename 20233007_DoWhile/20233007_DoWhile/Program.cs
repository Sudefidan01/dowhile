using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20233007_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Do While
            // While döngü mekanizmasında olduğu gibi koşula bağlı olarak çalışan bir döngü mekanizmasıdır
            //While mekanizmasının aksine ilk önce do içerisindeki komut satırları işlenir sonra while içerisindeki koşul doğruluğu kontrol edilir
            //Eğer koşul doğruluğu sağlanıyorsa döngü içerisine tekrar girer


            //Syntax
            // do
            // {
            //  Komut satırları
            //  Komut satırları
            //  Komut satırları
            // }while(koşul)

            //Örnek
            //Kullanıcıdan 2 adet sayı isteyelim
            //Bu sayıları toplayalım
            //Yeni bir işlem yapmak istiyor musunuz diye soralım
            //Cevap 'e' ise döngüyü baştan başlatalım

            char cevap;
            do
            {
                Console.Clear();
                Console.Write("Birinci Sayıyı Giriniz : ");
                int sayi1=int.Parse(Console.ReadLine());
                Console.Write("İkinci Sayıyı Giriniz : ");
                int sayi2=int.Parse(Console.ReadLine());
                int toplam=sayi1+sayi2;
                Console.WriteLine("Sayıların Toplamı = "+toplam);
                Console.WriteLine();

                Console.Write("Yeni bir işlem yapmak ister misiniz ?(e)");
                cevap=char.Parse(Console.ReadLine());

            } while (cevap=='e'||cevap=='E');
            Console.WriteLine("Programı kullandığınız için teşekkür ederiz");
            Console.WriteLine("Kapatmak için herhangi bir tuşa basınız");
            Console.ReadKey();

        }
    }
}
