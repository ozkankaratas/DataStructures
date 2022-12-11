using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VERI_YAPILARI_2
{
    internal class Program
    {
        class Block
        {
            public int data;
            public Block next; // kendi kendini point ediyor
            public Block prev;
        }
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            /// LINKED LIST (BAGLI LISTELER)
            /// 1-) Diziler statictir, run-time degistirilemez.Problem cozumleri icin uygundur ancak dinamic degildir.Sabit boyutludur.
            /// 2-) Dizilere insert (ekleme) yapilamaz.
            /// 3-) Delete problemi vardi. Dizilerden eleman silinemez
            /// Bu sorunlara cozum olarak LINKED LIST'ler cikmistir
            /// Once nesnel mimari incelenmeli
            /// string s = "ahmet"; bu s Ram'da 4 byte yer tutan bir pointer'dir. Degiskenler adresi tutar.
            /// polimorfizm ne kazandirir ? Virtual metodlar nelerdir?
            ////////////////////////////////////////////////////////////////////////////////////////////////////

            //Block bl = new Block(); // Block class'ina ait nesne olusturuldu
            //bl.data = 5;

            //Block bl2 = new Block();
            //bl2.data = 55;

            //Console.WriteLine(bl2.data);
            //bl2 = bl;
            //Console.WriteLine(bl2.data);
            //bl.next = bl2;
            //bl.data = 125;
            //Console.WriteLine(bl.data);
            //Console.WriteLine(bl2.next.data);
            //bl.next.next = new Block();
            //bl.next.next.data = 555;

            ////////////////////////////////////////////////////////////////////////////////////////////////////
            ////10 ELEMANLI ILK ELEMANI HEAD OLAN LISTE OLUSTURMA:
            //Block head = null; // pointer
            //Block last = null; // pointer
            //for (int i = 0; i < 10; i++)
            //{
            //    Block tmp = new Block();
            //    tmp.data = i;
            //    tmp.next = null;
            //    if (head == null)
            //        head = tmp;
            //    else
            //        last.next = tmp;
            //    last = tmp;
            //}
            //Block tt = head;
            //while (tt != null)
            //{
            //    Console.WriteLine(tt.data);
            //    tt = tt.next;
            //}
            //Console.ReadLine();


            ////////////////////////////////////////////////////////////////////////////////////////////////////
            ////10 ELEMANLI ILK ELEMANI HEAD OLAN LISTE OLUSTURMA ( optimizasyon ):
            //Block head = null; // pointer
            //Block last = null; // pointer
            //Block tmp = null;
            //for (int i = 0; i < 10; i++)
            //{
            //    tmp = new Block();
            //    tmp.data = i;
            //    tmp.next = last;
            //    last = tmp;
            //}
            //head = last;
            //Block tt = head;

            //while (tt != null)
            //{
            //    Console.WriteLine(tt.data);
            //    tt = tt.next;
            //}
            //Console.ReadLine();


            //////////////////////////////////////////////////////////////////////////////////////////////////////
            ///Head ilk elemana bakmak uzere;
            ///1- Listedeki cift elemanlari bulunuz
            ///2- Listenin basina yeni bir block ekleyiniz
            ///3- Listenin sonuna yeni bir block ekleyiniz
            ///4- Listenin ilk blogunu siliniz
            ///5- Listenin son elemanini siliniz
            ///6- Listenin 3.elemanindan sonra bir block ekleyiniz
            ///7- En son elemandan once yeni bir block ekleyiniz
            ///8- Data degeri '5' olan blocklari siliniz
            ///9- Data degeri '5' olan blocktan sonra yeni bir block ekleyiniz
            ///10- Data degeri '5' olan blocktan once eleman ekleyiniz
            ///11- Listenin aynisini ilk elemani first olacak sekilde kopyalayiniz
            ///12- Listenin tum elemanlarini tersten bir listeye ekleyiniz
            ///13- Bu liste circular linked list ise eleman sayisini bulunuz
            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #region SORU1
            //Block head = null;
            //Block last = null;
            //for (int i = 0; i < 10; i++)
            //{
            //    Block tmp = new Block();
            //    tmp.data = i;
            //    tmp.next = null;
            //    if (head == null)
            //        head = tmp;
            //    else
            //        last.next = tmp;
            //    last = tmp;
            //}

            //Block tt = head;
            //while (tt != null)
            //{
            //    if (tt.data % 2 == 0)
            //    {
            //        Console.WriteLine(tt.data);
            //    }
            //    tt = tt.next;
            //}
            //Console.ReadLine();
            #endregion

            #region SORU2
            //Block head = null;
            //Block last = null;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Block tmp = new Block();
            //    tmp.data = i;
            //    tmp.next = null;
            //    if (head == null)
            //        head = tmp;
            //    else
            //        last.next = tmp;
            //    last = tmp;
            //}

            //Block bl = new Block();
            //bl.data = 5;
            //bl.next = head;
            //head = bl;

            //while(bl != null)
            //{
            //    Console.WriteLine(bl.data);
            //    bl = bl.next;
            //}
            //Console.ReadLine();
            #endregion

            #region SORU3
            //Block head = null;
            //Block last = null;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Block tmp = new Block();
            //    tmp.data = i;
            //    tmp.next = null;
            //    if (head == null)
            //        head = tmp;
            //    else
            //        last.next = tmp;
            //    last = tmp;
            //}

            //Block bl = new Block();
            //bl.data = 77;
            //last.next = bl;
            //last = bl;

            //Block tt = head;
            //while (tt != null)
            //{
            //    Console.WriteLine(tt.data);
            //    tt = tt.next;
            //}
            //Console.ReadLine();
            #endregion

            #region SORU4
            //Block head = null;
            //Block last = null;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Block tmp = new Block();
            //    tmp.data = i;
            //    tmp.next = null;
            //    if (head == null)
            //        head = tmp;
            //    else
            //        last.next = tmp;
            //    last = tmp;
            //}

            //head = head.next;

            //Block tt = head;
            //while (tt != null)
            //{
            //    Console.WriteLine(tt.data);
            //    tt = tt.next;
            //}
            //Console.ReadLine();
            #endregion

            #region SORU5
            //Block head = null;
            //Block last = null;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Block tmp = new Block();
            //    tmp.data = i;
            //    tmp.next = null;
            //    if (head == null)
            //        head = tmp;
            //    else
            //        last.next = tmp;
            //    last = tmp;
            //}

            //Block tt = head;
            //while (tt.next.next != null)
            //{
            //    tt = tt.next;
            //}
            //tt.next = null;

            //Block ll = head;
            //while (ll != null)
            //{
            //    Console.WriteLine(ll.data);
            //    ll = ll.next;
            //}
            //Console.ReadLine();
            #endregion

            #region SORU6
            //Block head = null;
            //Block last = null;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Block tmp = new Block();
            //    tmp.data = i;
            //    tmp.next = null;
            //    if (head == null)
            //        head = tmp;
            //    else
            //        last.next = tmp;
            //    last = tmp;
            //}



            //Block bl = head;
            //int sayac = 1;
            //while (sayac < 3)
            //{
            //    sayac++;
            //    bl = bl.next;
            //} // aranan eleman bulundu



            //Block tt = new Block();
            //tt.data = 66;
            //tt.next = bl.next;
            //bl.next = tt;

            //bl = head;
            //while (bl != null)
            //{
            //    Console.WriteLine(bl.data);
            //    bl = bl.next;
            //}
            //Console.ReadLine();
            #endregion

            #region SORU7
            //Block head = null;
            //Block last = null;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Block tmp = new Block();
            //    tmp.data = i;
            //    tmp.next = null;
            //    if (head == null)
            //        head = tmp;
            //    else
            //        last.next = tmp;
            //    last = tmp;
            //}
            //Block ll = head;
            //while (ll.next.next != null)
            //{
            //    ll = ll.next;
            //} // sondan bir onceki eleman bulundu

            //Block tt = new Block();
            //tt.data = 542;
            //ll.next = tt;
            //tt.next = last;

            //Block bl = head;
            //while (bl != null)
            //{
            //    Console.WriteLine(bl.data);
            //    bl = bl.next;
            //}
            //Console.ReadLine();
            #endregion

            #region SORU8
            //Block head = null;
            //Block last = null;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Block tmp = new Block();
            //    tmp.data = i;
            //    tmp.next = null;
            //    if (head == null)
            //        head = tmp;
            //    else
            //        last.next = tmp;
            //    last = tmp;
            //}

            //Block ll = head;
            //while (ll.next != null)
            //{
            //    if (ll.next.data == 5)
            //    {
            //        ll.next = ll.next.next;
            //    }
            //    else
            //    {
            //        ll = ll.next;
            //    }
            //}
            //Block bl = head;
            //while (bl != null)
            //{
            //    Console.WriteLine(bl.data);
            //    bl = bl.next;
            //}
            //Console.ReadLine();
            #endregion



            ////////////////////////////////////////////////////////////////////////////////////////////////////
            /// DOUBLY LINKED LIST
            ////////////////////////////////////////////////////////////////////////////////////////////////////

            //// 10 elemanli ciftli linked Listeyi olusturma
            //Block head = null;
            //Block last = null;
            //for (int i = 0; i <= 10; i++)
            //{
            //    Block tmp = new Block();
            //    tmp.data = i;
            //    tmp.next = null;
            //    tmp.prev = last;

            //    if (head == null)
            //        head = tmp;
            //    else
            //        last.next = tmp;
            //    last = tmp;
            //}

            //Block tt = head;
            //while (tt != null)
            //{
            //    Console.WriteLine(tt.data);
            //    tt = tt.next;
            //}
            //Console.ReadLine();


            //////////////////////////////////////////////////////////////////////////////////////////////////////
            /// First, Listenin ilk elemanina bakmak uzere
            /// 1 - Yapiyi Dairesel Hale Getiriniz.
            /// 2 - Listenin basina data degeri -1 olan blogu ekleyiniz.
            /// 3 - Listenin sonuna data degeri 10 olan blogu ekleyiniz.
            /// 4 - Listenin ilk elemanini siliniz.
            /// 5 - Listenin son elemanini siliniz.
            /// 6 - Data degeri 5 olan bloktan sonra blok ekleyiniz.
            /// 7 - Data degeri 5 olan bloktan once blok ekleyiniz.
            /// 8 - Bastan itibaren 7.blogu siliniz.
            /// 9 - Liste icindeki 5'lerden sondan 2.yi siliniz.
            /// 10 - Blocklarin icerisinde 0-100 arasi random veri varsa en cok tekrar eden veriyi bulunuz.
            /// 11 - Tekli linked listi ciftliye ceviriniz.
            /// 12 - Bir dizi icerisindeki sirali olmayan verileri ciftli linked liste sirali olarak ekleyiniz
            /// GELISTIRME SORUSU : Linked listleri ile dosya yapisi 
            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #region 1
            //Block first = null;
            //Block last = null;
            //for (int i = 0; i < 10; i++)
            //{
            //    Block tmp = new Block();
            //    tmp.data = i;
            //    tmp.next = null;
            //    tmp.prev = last;

            //    if (first == null)
            //        first = tmp;
            //    else
            //        last.next = tmp;
            //    last = tmp;
            //}

            //Block bl = first;
            //while (bl.next != null) bl = bl.next;
            //bl.next = first;
            //first.prev = bl;

            //while(first != null)
            //{
            //    Console.WriteLine(first.data);
            //    first = first.next;
            //} // circular oldugu icin sonsuz dongu
            #endregion



        }
    }
}