﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region void metotlar

            //void CustomerList()
            // {
            //     Console.WriteLine("Ali Yıldız");
            //     Console.WriteLine("Ayşe Yıldız");
            //     Console.WriteLine("Hakan Öztürk");
            //     Console.WriteLine("Merve Çınar");
            // }

            // CustomerList();
            // CustomerList();
            // CustomerList();
            // CustomerList();

            //void sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}



            //sum(); 






            #endregion


            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethord(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethord("Mehmet Yıldırım");

            //void customerCard(string name, string surName)
            //{

            //    Console.WriteLine("Müşteri: " + name + surName);

            //}

            //customerCard("Mehmet", " Yıldız");
            //customerCard("Ayşegül", " Kaya");


            #endregion


            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);
            #endregion


            #region Geriye Değer Döndüren Metotlar


            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;    
            //}
            //Console.WriteLine(StudentCard());


            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar


            // string CountryCard(string countryName,string capital,string flagColar)
            // {
            //     string cardinfo = "Ülke: "+ countryName + " - Başkent: " + capital + " Bayrak Rengi: " + flagColar;
            //     return cardinfo;
            // }
            // string x, y, z;
            // Console.Write("Ülke Adını giriniz: ");
            // x=Console.ReadLine();

            // Console.Write("Başkenti Giriniz: ");
            // y=Console.ReadLine();

            // Console.Write("Bayrak Rengini Giriniz: ");
            // z=Console.ReadLine();


            //Console.WriteLine(CountryCard(x,y,z));

            // Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));






            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar


            //int Sum(int number1, int number2)
            //{
            //    int result =number1 + number2;
            //    return result;

            //}
            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));

            #endregion

             
            #region Örnek Uygulama

            //string examResult( string student  ,int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;

            //    if (result >= 50)
            //    {
            //        return student+ " isimli, Öğrenci Sınavı Geçti"+ " Ortalama: "+result;
            //    }

            //    else
            //    {
            //        return student + " isimli, Öğrenci Sınavı Geçemedi" + " Ortalama: " + result;
            //    }

            //}
            //Console.WriteLine(examResult("Ali", 25, 41, 55));
            //Console.WriteLine(examResult("Ayşe", 36, 88, 33));


            #endregion






            Console.Read();


        }
    }
}
