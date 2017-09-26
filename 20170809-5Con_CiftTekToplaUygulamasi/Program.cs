using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170809_5Con_CiftTekToplaUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcının girdiği 20 sayıdan çiftleri ve tekleri toplayıp ekrana yazan uygulamayı yazınız.
            //Uygulama içerisinde foreach döngüsü kullanılmalıdır.

            int[] sayilar = new int[20];
            int tekToplam = 0, ciftToplam = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write((i+1)+". Sayıyı giriniz : ");
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            foreach (int item in sayilar)
            {
                if (item % 2 == 0)
                {
                    ciftToplam += item;
                }
                else
                {
                    tekToplam += item;
                }
            }

            Console.WriteLine("Tek sayıların toplamı : {0}",tekToplam);
            Console.WriteLine("Çift sayıların toplamı : {0}", ciftToplam);

            //eğer metinleri tek bir Console.Write(); içerisinde yazmak istersek ve bunların yine de alt alta yazılmasını istiyorsak \n kullanırız \ karakteri kaçış karakteridir. Aynı zamanda \"  kullanarak string içerisinde çift tırnak işareti de kullanabiliriz.
            // \t 8 karakterlik boşluk bırakır TAB tuşuna basmış gibi olur.


            Console.Read();
        }
    }
}
