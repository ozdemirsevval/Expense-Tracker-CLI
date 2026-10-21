using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense_Tracker_CLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("===================\nHarcama Takipçisi\n===================\n" +
                   "1) Gelir ekle \n2) Gider ekle \n3) İşlemleri Listele \n4) Bakiyeyi Göster \n5) Çıkış");
                Console.Write("\nSeçiminiz : ");

                string secim = Console.ReadLine();
                while (true)
                {
                    if (secim == "1")
                    {
                        Console.Write("Gelir Ekleyiniz.\n");
                        Console.WriteLine("Gelir Açıklamasını Yazınız.");
                        string aciklama = Console.ReadLine();
                        Console.WriteLine("Gelir Miktarınızı Yazınız.");
                        string gelir = Console.ReadLine();
                        Console.Write($"Açıklama: {aciklama} | Gelir Miktarı: {gelir}\n");
                        Console.WriteLine("Kullanıcımız bilgilerinizi doğrulamanızı rica ederiz.\n"
                            + "\na) Yeniden Giriş Sağlayınız \nb)Kaydedip Ana Menüye Dönüş Sağlayınız.");
                        string dogrulama = Console.ReadLine();

                        if (dogrulama == "a")
                        {
                            Console.Clear();
                            continue;
                        }
                        else if (dogrulama == "b")
                        {
                            break;
                        }
                    }
                    else if (secim == "2")
                    {
                        Console.WriteLine("Gider Ekleyiniz.\n");
                        Console.WriteLine("Gider Açıklamasını Yazınız.");
                        string aciklama = Console.ReadLine();
                        Console.WriteLine("Gider Miktarını Yazınız.");
                        string gider = Console.ReadLine();
                        Console.WriteLine($"Açıklama: {aciklama} | Gider Miktarı: {gider}\n");
                        Console.WriteLine("Kullanıcımız bilgilerinizi doğrulamanızı rica ederiz.\n"
                            + "\na) Yeniden Giriş Sağlayınız \nb)Kaydedip Ana Menüye Dönüş Sağlayınız.");
                        string dogrulama = Console.ReadLine();

                        if (dogrulama == "a")
                        {
                            Console.Clear();
                            continue;
                        }
                        else if(dogrulama == "b")
                        {
                            break;
                        }

                    }
                }
            }
        }
    }
}
