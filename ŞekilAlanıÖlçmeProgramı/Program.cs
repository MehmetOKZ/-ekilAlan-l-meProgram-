using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŞekilAlanıÖlçmeProgramı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cevap;
            float sonuç;

            Console.WriteLine("Alanını bulmak istediğiniz şekil nedir? Lütfen dikdörtgen için 'd' veya daire için herhangi bir tuş kullanınız.");
            
            cevap = Console.ReadLine();

            if (cevap == "d")
            {
                Console.WriteLine("Lütfen dikdörtgenin yüksekliğini giriniz. ");
                float yükseklik = float.Parse(Console.ReadLine());

                Console.WriteLine("Lütfen dikdörtgenin genişliğini giriniz. ");
                float genişlik = float.Parse(Console.ReadLine());

                sonuç = yükseklik * genişlik;

            }
            else
            {
                Console.WriteLine("Lütfen çemberin yarıçapını giriniz");
                float yarıçap = float.Parse(Console.ReadLine());

                sonuç = (float)Math.PI * (yarıçap * yarıçap);
            }
            Console.WriteLine("Sonuç " + sonuç);
            Console.ReadKey();
        }
    }
}
