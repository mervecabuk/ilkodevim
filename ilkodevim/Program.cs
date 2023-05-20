using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilkodevim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cinsiyetinizi girin (Erkek/Kadın):");
            string cinsiyet = Console.ReadLine();

            switch (cinsiyet.ToLower())
            {
                case "erkek":
                    // Erkek işlemleri
                    Console.WriteLine("Yaşınızı girin:");
                    int yasErkek = Convert.ToInt32(Console.ReadLine());

                    if (yasErkek >= 60)
                    {
                        Console.WriteLine("Maaşınızın 10 katı kadar ikramiye alarak emekli edileceksiniz.");
                    }
                    else
                    {
                        Console.WriteLine("Çalıştığınız gün sayısını girin:");
                        int calismaGunleri = Convert.ToInt32(Console.ReadLine());

                        if (calismaGunleri >= 6000)
                        {
                            Console.WriteLine("Maaşınızın 11 katı kadar ikramiye alarak emekli edileceksiniz.");
                        }
                        else
                        {
                            Console.WriteLine("Emekli edilmeyeceksiniz.");
                        }
                    }

                    break;

                case "kadın":
                    // Kadın işlemleri
                    Console.WriteLine("Yaşınızı girin:");
                    int yasKadin = Convert.ToInt32(Console.ReadLine());

                    if (yasKadin >= 58)
                    {
                        Console.WriteLine("Maaşınızın 10 katı kadar ikramiye alarak emekli edileceksiniz.");
                    }
                    else
                    {
                        Console.WriteLine("Çalıştığınız gün sayısını girin:");
                        int calismaGunleri = Convert.ToInt32(Console.ReadLine());

                        if (calismaGunleri >= 4500)
                        {
                            Console.WriteLine("Maaşınızın 11 katı kadar ikramiye alarak emekli edileceksiniz.");
                        }
                        else
                        {
                            Console.WriteLine("Emekli edilmeyeceksiniz.");
                        }
                    }

                    break;

                default:
                    Console.WriteLine("Geçersiz cinsiyet bilgisi girdiniz.");
                    break;
            }

        }
    }
}
