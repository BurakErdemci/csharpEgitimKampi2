using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü 

            //int i;
            //for (i=1; i<=5; i++)
            //{
            //    Console.WriteLine("Csharp Eğitim Kampı ");
            //}


            //for (int i =1; i<=20;  i++)
            //{

            //    Console.WriteLine(i);
            //}



            //for (int i= 3; i<=51; i+=3)
            //{

            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adeti girin: ");
            //int finishValue=int.Parse(Console.ReadLine());
            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşa Mustafa Kemal Paşa");
            //}

            #endregion

            #region for döngüsü ile karar yapıları

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //int totalValue=0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);


            //int totalvalue = 0;
            //for (int i = 1; i <= 20; i++)
            //{
            //    if(i% 2 ==0)
            //    {
            //        totalvalue += i;
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.WriteLine("------------+");
            //Console.WriteLine(totalvalue);

            //int count = 0;
            //for( int i=1; i<=60; i++)
            //{
            //    if(i%7 ==0)
            //    {

            //        count++;
            //    }
            //}

            //Console.WriteLine(count);

            //int bacterium = 1;
            //for(int i=1; i<=24; i++)
            //{

            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat Sonunda " + bacterium);
            //}



            #endregion

            #region while döngüsü

            //int i = 1;
            //while (i<=10)
            //{
            //    Console.WriteLine("Merhaba döngüler");
            //    i++;
            //}
            //int i = 1;
            //while(i<=10)
            //{
            //    if(i %3==0)
            //    {

            //        Console.WriteLine(i);
            //    }
            //    i++;

            //}

            //int i = 1;
            //int sum = 1;
            //while (i <= 10)
            //{

            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);










            #endregion

            #region  Örnek Sınav Sorusu


          //  Console.Write("Lütfen 3 basamaklı sayı girini: ");
          //  int number;
          //  number= int.Parse(Console.ReadLine());

          //  int ones, tens, hundreds, total;

          //if (number < 100 || number>999)
          //      {

          //      Console.Write("Hatalı giriş");

          //  }

          //  else
          //  {




          //      ones = number % 10;
          //      Console.WriteLine("Birler Basamağı: " + ones);
          //      tens = (number % 100) / 10;
          //      Console.WriteLine("Onlar Basamağı: " + tens);
          //      hundreds = number / 100;
          //      Console.WriteLine("Yüzler Basamağı:" + hundreds);
          //      total = ones + tens + hundreds;
          //      Console.WriteLine();
          //      Console.WriteLine("Basamaklar Toplamı Sonucu = " + total);



          //  }


            #endregion 

            Console.Read();

        }
    }
}
