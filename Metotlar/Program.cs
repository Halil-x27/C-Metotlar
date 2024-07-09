using System;

namespace Metotlar
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 3;
            int b = 2;

            Console.WriteLine(a+b);

            int sonuc = topla(a,b);

            Console.WriteLine(sonuc);


            Metotlar ornek = new Metotlar();
            ornek.ekranaYazdir(Convert.ToString(sonuc));

            int sonuc1 = ornek.ArttirVeTopla(a,b);
            ornek.ekranaYazdir(Convert.ToString(sonuc1));

        }

       static int topla(int sayi1, int sayi2) 
        {
            return(sayi1 + sayi2);
        }

       
    }
     public class Metotlar
        { 
            public void ekranaYazdir(string veri)
            {
                Console.WriteLine(veri);
            }


            public int ArttirVeTopla(int deger1, int deger2)
            {
                deger1+=1;
                deger2+=1;
                return deger1 + deger2;
            }

        }
}