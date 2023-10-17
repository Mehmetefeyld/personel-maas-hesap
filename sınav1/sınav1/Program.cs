using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınav1
{

    class hesapla
    {
        public static void ucretBul(string isim, int saat, char bolum)
        {
            double saatUcreti;
            if (bolum == 'a')
                saatUcreti = 21;
            else if (bolum == 'ü')
                saatUcreti = 19;
            else
            {
                Console.WriteLine("{0} için geçersiz bölüm girildi.", isim);
                return;
            }

            double maas;
            if (saat <= 40)
                maas = saatUcreti * saat;
            else
                maas = (40 * saatUcreti) + ((saat - 40) * saatUcreti * 1.2);

            Console.WriteLine("{0} için hesaplanan maaş: {1} TL", isim, maas);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Personel sayısını giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("\nPersonel {0} bilgileri:", i);
                Console.Write("İsim: ");
                string isim = Console.ReadLine();
                Console.Write("Çalışma saati: ");
                int saat = Convert.ToInt32(Console.ReadLine());
                Console.Write("Bölüm (a/ü): ");
                char bolum = Convert.ToChar(Console.ReadLine());

                hesapla.ucretBul(isim, saat, bolum);
            }

            Console.ReadKey();
        }
    }
}