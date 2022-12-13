using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;

namespace VERI_YAPILARI_3
{
    internal class Program
    {
        // Static degiskenler class'dan nesne olusturmadan da kullanilabilir

        static int[] stack = new int[100]; // Stackler RAM'de dizi olarak veya linked list olarak tutulabilir
        static int sp = -1; // Stack pointer

        static void push(int data)
        {
            sp++;
            stack[sp] = data;
        }

        static int pop()
        {
            int data = stack[sp];
            sp--;
            return data;
        }

        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// STACKLER (YIGIN)
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// Verilerin toplandigi bir ambardir.
            /// Bu verilerin giris ve cikis kurallari vardir.
            /// Interrupt'lari destekler.
            /// Isletim sistemi cok yerde stack kullanir.
            /// Oyun yazilimlari stacklari kullanir.
            /// Bazi yazilimlarda stack kullanilir (otomasyon).
            /// Compiler (Derleyici) tarafindan kullanilir.
            /// Infix , Postfix ' de kullanilir. (Mulakatlarda zor soru olarak sorulur)
            /// Method cagirmalarda kullanilir. Return adresleri stack'e atilir
            /// LIFO (Last In First Out) = Ogretmenlerin defterleri toplamasi
            /// Stack'a veri gondermek = PUSH
            /// Stack'tan veri almak   = POP
            /// Stack Pointer (SP) = Gelen ve Giden veriyi denetler. Default degeri -1'dir.
            /// PUSH yapilacagi zaman SP = SP + 1 olur , POP yapilacagi zaman SP = SP - 1 olur.
            //////////////////////////////////////////////////////////////////////////////////////////////////////////

            #region Palindrom
            // "mum" , "12321"  , "11111" palindromik ifadelerdir

            //string s = "oto";

            //for (int i = 0; i < s.Length; i++)
            //{
            //    push((byte)s[i]);
            //}

            //int palindrom = 1; // sart kontrolu
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i] != pop())
            //    {
            //        palindrom = 0;
            //        break;
            //    }
            //}
            //if (palindrom == 1)
            //{
            //    Console.WriteLine("palindromdur");
            //}
            //else
            //{
            //    Console.WriteLine("palindrom degildir");
            //}
            //Console.ReadLine();
            #endregion

            #region Alt Dizinleri Yazdirmak
            //Stack<string> st = new Stack<string>();
            //st.Push(@"C:\Users\Ozkan\Desktop\Lessons\3.SINIF 1.DONEM\bilgisayar mimarisi");
            //while (st.Count > 0)
            //{
            //    string path = st.Pop();
            //    string[] dizinler = Directory.GetDirectories(path);
            //    string[] files = Directory.GetFiles(path);

            //    for (int i = 0; i < dizinler.Length; i++)
            //    {
            //        st.Push(dizinler[i]);
            //    }
            //    foreach (string item in files)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //Console.ReadLine();
            #endregion

            #region Parantez Karsiliklari

            //// {, [, (
            //int hata = 0;
            //string s = "([{}])";
            //string left  = "{[(";
            //string right = "}])";
            //for (int i = 0; i < s.Length; i++)
            //{
            //    int indis = left.IndexOf(s[i].ToString());
            //    if (indis != -1)
            //    {
            //        push(right[indis]);
            //    }
            //    else
            //    {
            //        indis = right.IndexOf(s[i].ToString());
            //        if (indis != -1)
            //        {
            //            if (pop() != right[indis])
            //            {
            //                hata = 1;
            //                break;
            //            }
            //        }
            //    }
            //}
            //if (hata == 0)
            //{
            //    Console.WriteLine("dogru");
            //}
            //else Console.WriteLine("yanlis");

            //Console.ReadLine();

            #endregion

        }
    }
}
