using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace altan_hoca_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cinsiyet bilgisi girini: (ERKEK/KADIN)");
            string cinsiyet = Console.ReadLine().ToUpper();
            Console.WriteLine("Yaş bilgisi giriniz");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Çalışılan gün bilgisi giriniz");
            double gun = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Maaş bilgisi giriniz :");
            double maas = Convert.ToDouble(Console.ReadLine());
            

            switch (cinsiyet)
            {
                case "ERKEK":
                    if ( yas> 60)
                    {
                        Console.WriteLine("Maaşınızın 10 katı değerinde ikramiye " + (maas*10));

                    }
                    else if(yas<60 && gun>6000) 
                    {
                        //int ikramiye = yas * 11;
                        Console.WriteLine("İkramiyeniz : " + (maas*11));
                    }
                    else if(yas<60 && gun<6000)
                    {
                        Console.WriteLine("Herhangi bir ikramiye alamazsınız....");
                    }
                    else
                    {
                        Console.WriteLine("Hatalı yaş veya gün bilgisi girildi");
                    }
                    break;

                case "KADIN":
                    if (yas > 58)
                    {
                        Console.WriteLine("Maaşınızın 10 katı değerinde ikramiye " + (maas * 10));

                    }
                    else if (yas < 58 && gun >= 4500)
                    { 
                        
                        Console.WriteLine("İkramiyeniz : " + (maas * 11));
                    }
                    else if (yas < 58 && gun < 4500)
                    {
                        Console.WriteLine("Herhangi bir ikramiye alamazsınız....");
                    }
                    else
                    {
                        Console.WriteLine("Hatalı yaş veya gün bilgisi girildi");
                    }
                    break;

               
       

            }
            Console.ReadLine();

        }
    }
}
