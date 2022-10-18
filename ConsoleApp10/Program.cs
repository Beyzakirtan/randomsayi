using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan rastegele sayı al,tahmin al,bilemezse tahmin sayacını arttır,bilirse tebrikler
            Random sayiGen = new Random();
            int sayi = sayiGen.Next(1, 101);
            bool bulundu = false;
            int tahminSayisi = 1;
            while (bulundu==false)
            {
                Console.WriteLine("1-100 arası");
                int tahmin = Convert.ToInt32(Console.ReadLine());
                if(tahmin==sayi)
                {

                    bulundu = true;
                    Console.WriteLine("tebrikler{0}", tahminSayisi);


                }
                else
                {
                    tahminSayisi++;
                    if (tahmin > sayi)
                    {
                        Console.WriteLine("tahmini kucult");
                    }
                    else
                    { 
                        Console.WriteLine("tahmini büyüt");
                    }
                        
                        
                        
                }


            }
        
        
        
        }
    }
}
