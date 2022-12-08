using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace VERI_YAPILARI
{
    internal class Program
    {
        // IP(Instruction Pointer) veya PC(Program Counter) nereyi point ederse orasi calisir   FETCH/DECODE/EXECUTE   =   OKU/YORUMLA/GERCEKLESTIR

        // Ilk veri yapisi degiskenlerdir

        // Nesneler pointerdir. Pointerlar adres tutar.

        // Stringlerde uzerine yazmak yoktur yeni adresler olusturulup oraya yazilir bu yuzden string kullanmak performans acisindan iyi degildir

        // Dizinin elemanlari arasinda bosluk olamaz

        // x[indis] = BA + indis * 4  ( BA : Baslangic Adresi ) (DIZILERDE)

        static void Main(string[] args)
        {
            #region 1.ders
            //======================================================================================================================================
            int[,] y = new int[3, 4];
            int[,,] z = new int[2, 3, 4];
            int[,,,] q = new int[2, 3, 2, 3];

            //q[1, 2, 1, 2] = 122;
            //[b1, b2, b3, b4]
            //[i1, i2, i3, i4]
            //ba + i1 * b2 * b3 * b4 * 4 + i2 * b3 * b4 * 4 + i3 * b4 * 4 + i4 * 4
            //x[indis]  BA + indis * 4

            //======================================================================================================================================


            //// Fakulteler, bolumler, program, sinif bilgileri

            //int[,,,] kku = new int[10, 12, 2, 4];  // Fakulte/Bolum/Ogrenim/Sinif 
            //kku[0, 0, 0, 1] = 200; // Muhendislik/Bilg.Muh/NormalOgretim/1.sinif   

            //// Bir fakultedeki en fazla ogrenci sayisi
            //int toplam = 0;
            //int ebs = 0; // en buyuk sayi
            //for (int i = 0; i < 10; i++) // fakulteler
            //{
            //    toplam = 0;
            //    for (int j = 0; j < 12; j++) // bolum
            //    {
            //        for (int k = 0; k < 2; k++) // ogrenim
            //        {
            //            toplam += kku[i, j, k, 0];
            //        }
            //    }
            //    if (toplam > ebs) ebs = toplam;
            //}

            //======================================================================================================================================

            // ODEV !!! Klavyeden alinan n boyutlu dizinin bir elemanina ulasip adresini yazdir

            //int[,,,] hastane = new int[2, 3, 2, 3]; // kadrolu personel - sozlesmeli personel /// saglik personeli - memur - temizlik personeli 
            // gunduz calisani - gece calisani /// a blok - b blok - c blok

            //Console.WriteLine("ID Ogrenme Paneli \n");
            //int istenen = Convert.ToInt32(Console.ReadLine());


            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        for (int k = 0; k < 2; k++)
            //        {
            //            for (int l = 0; l < 3; l++)
            //            {
            //                if (istenen == hastane[i, j, k, l]) istenen = hastane[i, j, k, l];
            //            }
            //        }
            //    }

            //}
            //Console.WriteLine(istenen);
            //Console.ReadLine();

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            // int[b1,b2,b3,b4,b5,b6] // b : boyutt
            // int[i1,i2,i3,i4,i5,i6]. indexlerine ulasalim // i : indis
            // i1*b2*b3*b4*b5*b6*4 + i2*b3*b4*b5*b6*4 + i3*b4*b5*b6*4 + i4*b5*b6*4 + i5*b6*4 + i6*4


            #endregion

            #region 2.ders
            // 1+2-3-4+5+6+7-8-9-10-11
            //int toplam = 0;
            //int flag = -1;
            //int adt = 2;
            //int flg = 0;
            //for (int i = 3; i <+ 100; i++)
            //{
            //    toplam = toplam + flag*i;
            //    flg++;
            //    if(adt == flg)
            //    {
            //        flag = flag * -1;
            //        adt++;
            //    }
            //}

            //bilg(1);
            //sum(1);
            //sum2(1,1);
            //Console.ReadLine();

            //// Bir ulkede secim vardir. 100 Il , 20 Ilce , 50 Mahalle , 100 Sandik
            //// En fazla oy kullanilan ili bulunuz
            int[,,,] secim = new int[100, 20, 50, 100];
            //int toplam = 0;
            //int efs = 0;        // en fazla secmen
            //int efsindis = 0;   // en fazla secmen indisi

            //for (int i = 0; i < 100; i++)
            //{
            //    toplam = 0;
            //    for (int j = 0; j < 20; j++)
            //    {
            //        for (int k = 0; k < 50; k++)
            //        {
            //            for (int l = 0; l < 100; l++)
            //            {
            //                toplam = toplam + secim[i, j, k, l];
            //            }
            //        }
            //    }
            //    if(efs < toplam)
            //    {
            //        efs = toplam;
            //        efsindis = i;
            //    }
            //}

            // En fazla oy kullanilan ikinci il ??
            //int toplam = 0;
            //int efs1 = 0;  // en fazla secmen olan il
            //int efs2 = 0;  // emn fazla secmen olan 2. il
            //int efsi1 = 0;
            //int efsi2 = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    toplam = 0;
            //    for (int j = 0; j < 20; j++)
            //    {
            //        for (int k = 0; k < 50; k++)
            //        {
            //            for (int l = 0; l < 100; l++)
            //            {
            //                toplam = toplam + secim[i, j, k, l];
            //            }
            //        }
            //    }
            //    if (toplam > efs1)
            //    {
            //        efs2 = efs1;
            //        efsi2 = efsi1;
            //        efs1 = toplam;
            //        efsi2 = i;
            //    }
            //    else if (toplam > efs2)
            //    {
            //        efs2 = toplam;
            //        efsi2 = 1;
            //    }
            //}



            // Bu soruyu tek boyutlu dizi olarak cozersek ;
            //int[] tbd = new int[1000000]; // seklinde dizi yapmaliyiz


            //  ODEVLER
            //  1- Soruyu recursive olarak  (ONCE BIR DIZININ EN BUYUK ELEMANI BUL.i,j,k,l parametre olarak al)
            //  2- Tek dongu icinde coz
            //  3- En fazla oy kullanilan 5.ili bul
            #endregion
            //Console.WriteLine(bilg(1, 1));
            //Console.ReadLine();
        }

        /*static int bilg(int a, int flag)
        {
            if (a >= 101) return 0;
            return a * flag + bilg(a + 1, flag * -1);
        }*/

        #region 2.ders RECURSIVE 
        //static void bilg(int a)
        //{
        //    if (a >= 15) return;
        //    Console.WriteLine(a);
        //    bilg(a = a + 2);
        //}

        //static int sum(int a)
        //{
        //    if (a >= 100) return 0;
        //    return a + sum(a + 1);
        //}

        // 1-2+3-4+5-6+7....-100
        //static int sum2(int a , int flag)
        //{
        //    if (a <= 8) return 0;
        //    return a*flag + sum2(a + 1,flag*-1);
        //}
        #endregion

    }
}

