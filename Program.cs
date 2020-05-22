using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitabevi.app
{
   public class Program
    {

        

        static void Main(string[] args)

        {
            
            Kitap[] kitapevi = new Kitap[0];
            string cikis = "";
            while (cikis != "E")
            {
                Console.WriteLine("-------------HOŞGELDİN-------------");
                Console.WriteLine("Kitap eklemek için 1 e \n listeyi görmek için 2 ye tıklayın");
                int liste = int.Parse(Console.ReadLine());
                if (liste==1)
                {
                    Console.WriteLine("kaç kitap ekleyeceksiniz");
                    int kitapsayi = int.Parse(Console.ReadLine());
                    kitapevi = new Kitap[kitapsayi];
                    for (int i = 0; i < kitapsayi; i++)
                    {
                        Kitap ktp1 = new Kitap();
                        Console.WriteLine("{0}. kitap içi bilgileri giriniz", i+1);
                        Console.WriteLine($"kitabın adı:");
                        ktp1.SetKitapadi(Console.ReadLine());
                        Console.WriteLine($"kitabın yazarı:");
                        ktp1.SetYazaradi(Console.ReadLine());
                        Console.WriteLine($"kitabın türü:");
                        ktp1.SetKitaptürü(Console.ReadLine());
                        Console.WriteLine("kitabın basıldığı yıl");
                        ktp1.SetBasimtarihi(int.Parse(Console.ReadLine()));
                        
                    }


                }
                else if (liste==2)
                {
                 
                }

            }



            



            Console.ReadKey();
        }
        

    }
}
