using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _CanberkAyhan
{
    class Program
    {
        static void Main(string[] args)
        {
 

            int B;
            int flort;
            int K = 0;

            Console.Write("Grafınızda bulunan düğüm sayısı = ");
            B = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sonsuz değer tanımı değerini gir= ");
            flort = Convert.ToInt32(Console.ReadLine());

            int[,] D = new int[B, B]; 

            for (int i = 0; i < B; i++)
            {
                for (int j = 0; j < B; j++)
                {
                    Console.Write(" " + (i + 1) + ". satir " + (j + 1) + ". sutun ");
                    D[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            
            while (K <= (B - 1))
            {
                for (int i = 0; i < B; i++)
                {
                    if (K == i)
                    {
                        continue;
                    }

                    for (int j = 0; j < B; j++)
                    {
                        if (K == j)
                        {
                            continue;
                        }

                        int hucre = D[i, j];
                        int karsilastirilanDeger = D[i, K] + D[K, j];

                        if (karsilastirilanDeger < hucre)
                        {
                            D[i, j] = karsilastirilanDeger;
                            
                        }
                    }
                }
                K++;
            }


            Console.WriteLine("Floyd uygulandıktan sonra elde edilen matrisi; ");
            Console.WriteLine("Hesaplanan matrisin boyutu= " + B + "x" + B + " ve Graftaki sonsuz uzaklık değeri= " + flort + " seçilmiştri!");
            Console.WriteLine("<______________________________________________________________>");
         
            for (int i = 0; i < B; i++)
            {
                for (int j = 0; j < B; j++)
                {
                    Console.Write(D[i, j] + "| ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("<______________________________________________________________>");



            

            char tercih = 'E';

            
                int baslangicDogumu;
                int varisDugumu;

                Console.Write("Başlangıç düğümünü gir= ");
                baslangicDogumu = Convert.ToInt32(Console.ReadLine());

                Console.Write("Varış düğümünü gir= ");
                varisDugumu = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("*________________________________________________________________________________*");
                Console.Write(baslangicDogumu + ". düğümden " + varisDugumu + ". düğüme en kısa yol= ");
                Console.WriteLine(D[baslangicDogumu - 1, varisDugumu - 1]);
                Console.WriteLine("*________________________________________________________________________________*");

         

            Console.ReadKey();
        }
    }
}


