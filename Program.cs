
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AsalMi
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba konsoldan girilen bir degerin asal olup olmadıgı bilgisini paylasabilirim\n" +
                "Bunu yapmamı ister misin? e veya h");
            while (true)
            {
                string komut = Console.ReadLine();

                if (komut == "e" || komut == "E")
                {
                    Asalmi();
                    break;
                }
                else if (komut == "h" || komut == "H")
                {
                    Console.WriteLine("Anlaşıldı. Programdan cikiyorum"); break;
                }
                else
                {
                    Console.WriteLine("Komut anlasilamadi tekrar deneyiniz");
                    continue;
                }
                
            }

            Console.WriteLine("loglandı");
            Console.ReadLine();
        }

        private static void Asalmi()
        {
            Console.WriteLine("Lutfen pozitif bir tamsayi giriniz: ");
            int num;
            while (true)
            {
                num = DegerAl();
                if (num <= 1)
                {
                    Console.WriteLine("Girdiginiz sayi 1 den buyuk bir tam sayi olmalidir, baska bir sayi giriniz:\n");

                }
                else
                {
                    bool condition = true;
                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0 && num != 2)
                        {
                            condition = false;
                            break;
                        }
                    }
                    if (condition) Console.WriteLine("Girdiginiz sayi asaldır");
                    else Console.WriteLine("Girdiginiz sayi asal degildir");
                    break;
                }
            }
            Console.WriteLine("Programdan cıkmak icin c tekrar denemek icin t basiniz");

           
            
            while (true)
            {
                string komut = Console.ReadLine();
                if (komut == "c" || komut == "C")
                {
                    Console.WriteLine("Programdan basariyla cikildi.");
                    break;
                }
                    
                    
                   
                else if (komut == "t" || komut == "T")
                {
                    Asalmi();
                    break;
                }
                    
                    
                else
                {
                    Console.WriteLine("Komut anlasilamadi tekrar deneyiniz");
                    continue;
                }
                
            }
            
        }

        private static int DegerAl()
        {
            string deger;
            deger = Console.ReadLine();
            int num = 0;
            while (!int.TryParse(deger, out num))
            {
                Console.Write("Girdiginiz deger hatalıdır, lutfen pozitif bir tam sayı giriniz\n");
                deger = Console.ReadLine();
            }
            return num;
        }

    }
}

