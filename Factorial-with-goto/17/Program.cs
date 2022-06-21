using System;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faktöriyelini almak istediğiniz sayıyı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int faktoriyel = 1, sayac = 1;

            kontrol: if (sayi == 0)
            {
                faktoriyel = 1;
                goto ekranaYaz;
            }
            else if (sayi <0 )
            {
                goto negatifSayi;
            }
            else if (sayi > sayac)
            {
                sayac++;
            }
            else
            {
                goto ekranaYaz;
            }

            faktoriyel = faktoriyel * sayac;
            goto kontrol;

        ekranaYaz: Console.WriteLine("Girilen sayı : " + sayi + " Faktöriyeli : " + faktoriyel);
            goto bitir;
        negatifSayi: Console.WriteLine("Negatif sayıların faktöriyeli olmaz!");
        bitir: Console.ReadLine();



        }
    }
}
