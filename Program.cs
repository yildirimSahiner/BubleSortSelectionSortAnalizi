using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayi = new int[10];
            int rastsayi, adet = 0;
            Random rastgele = new Random();

            //sayi dizimize rastgele sayı atayalım.
            for (int i = 0; i < 10; i++)
            {
                //1 ile 50 arasında sayı üretmek için.
                rastsayi = rastgele.Next(1, 50);
                sayi[i] = rastsayi;
            }
                   
          
            Console.WriteLine("selection sort Toplam swap sayısı : " + selSort(sayi) + " olarak bulundu.");
            Console.WriteLine();
            Console.ReadKey();
        }

        //bubble sort algoritması
        public static int bubble(int[] dizi)
        {
            int swap = 0;
            int karsilastir = 0;
            for (int i = 0; i < dizi.Length - 1; i++)
            {
                for (int j = 1; j < dizi.Length - i; j++)
                {
                    karsilastir = karsilastir + 1;
                    if (dizi[j] < dizi[j - 1])
                    {
                        swap = swap + 1;
                        int gecici = dizi[j - 1];
                        dizi[j - 1] = dizi[j];
                        dizi[j] = gecici;
                    }
                }

            }
            Console.WriteLine("şu elaman" + karsilastir + "defa karşılaştırılıyor.");
            return swap;
        }

    /// Selection Sort algoritması
        public static int selSort(int[] arr)
            {
            int swap = 0;
            int karsilastir = 0;
                int maxIndex, temp;
                for (int i = arr.Length - 1; i > 0; i--)
                {
                    maxIndex = 0;

                    for (int j = 1; j <= i; j++)
                    {
                        karsilastir = karsilastir + 1;
                        if (arr[j] > arr[maxIndex])
                            swap = swap + 1;
                            maxIndex = j;
                    }
                    temp = arr[maxIndex];
                    arr[maxIndex] = arr[i];
                    arr[i] = temp;
                }
                Console.WriteLine("şu elaman" + karsilastir + "defa karşılaştırılıyor.");
                return swap;
            }
         
        }
   
}



