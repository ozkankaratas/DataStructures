using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERI_YAPILARI_4
{
    class Block
    {
        public int data;
        public Block next;
        public Block prev;
    }
    class Program
    {
        // STACKLER LINKED LISTLER ILE DE TANIMLANABILIR

        static Block sp = null;  // STACK POINTER
        static void push(int data)
        {
            Block bl = new Block();
            bl.data = data;
            bl.next = null;
            bl.prev = null;
            if (sp != null)
            {
                sp.prev = bl;
                bl.next = sp;
            }
            sp = bl;
        }

        static int pop()
        {
            int data = sp.data;
            sp = sp.next;
            return data;
        }

        static int peek()   // pop() islemi yapmadan veriyi gormek
        {
            return sp.data;
        }

        static int toplam(int a, int b)
        { return a + b; }
        static int fark(int a, int b)
        { return a - b; }
        static int carpim(int a, int b)
        { return a * b; }
        static int bolum(int a, int b)
        { return a / b; }

        static void Main(string[] args)
        {
            #region STACK BILGI
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// Stacklerin bir baska kullanimi matematiksel ifadelerdir.
            /// A = b*c-d/f+x*y tipinde bir soruyu compiler nasil hesaplar ???
            /// Matematiksel olan ifadelere INFIX IFADELER denir.
            /// Infix ifadeler parantezler ve islem oncelikleri icerir ancak compilerin bunu anlamasi icin onceliklerden arindirilmalidir.
            /// Bunun icin INFIX'den POSTFIX veya PREFIX'e gecilir.
            /// "A + B" ifadesinin POSTFIX yaziminda operatorun sagi ve solu kullanilir = "AB+" olur.
            /// "A + B" ifadesinin PREFIX yaziminda operatorun sagi ve solu kullanilir = "+AB" olur.
            /// Kurallar aynidir ancak derste POSTFIX uzerinden ilerleyecegiz.
            /// "A + B + C" = "ABC++" veya "AB+C+" olur.
            /// "A - B + C" = "AB-C+"
            /// "A - B - C" = "ABC--"
            /// "A + B * C" = "ABC*+"
            /// "A * B - F/(G + H)" = "AB*FGH+/-"
            /// "A/(B * (D - F/(B - B * A + D) + H) + X) + J" = ABDFBBA * D+-/H+-*X+/J+

            /// Bu sorulari Stack'ler ile cozebiliriz
            /// - Operandlar postfix'e , Operatorler stack'e eklenir
            /// Ancak stack'e atilirken, stack icindeki deger yeni push etcegimiz degerden buyuk ve esitse stack icindeki pop edilir. Elimizdeki pop edilir.
            /// Sol parantez gorunce direkt stack icine atilir.
            /// Sag parantez gorunce arti ve eksi pop edilir.
            /// a * (b + c * d / f + h) - g
            /// POSTFIX = abcd*f/h++*g-
            /// STACK = *(++
            /// bir infix ifadede kac degisken kullanildi ve degiskenleri yazdirin
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            #endregion



            #region INFIX to POSTFIX 
            //string str1 = "A/(B*(D-F/(B-B*A+D)+H)+X)+J";
            //string str2 = "(3+4)*(242-84)+(8+2)/24";
            //string infix = str2;
            //string postfix = "";
            //string op = "$(+-*/)";           // $ ifadesi stack en basta bos degeri tutmasi icindir // Operandlar
            //string oncelik = "0011220";      // Sirasiyla oncelik atiyoruz
            //push((byte)'$');
            //for (int i = 0; i < infix.Length; i++)
            //{
            //    char ch = infix[i];     // Hizlandirmak icin yapildi !
            //    if (op.IndexOf(ch) == -1)      // == -1 demek bulunamadi demek
            //    {
            //        postfix = postfix + ch;
            //        continue;   // else kullanmak yerine continue kullandik, daha okunabilir
            //    }
            //    if (ch == '(')
            //    {
            //        push((byte)'(');
            //        continue;
            //    }
            //    if (ch == ')')
            //    {
            //        while (peek() != (byte)'(')
            //        {
            //            postfix = postfix + (char)pop();
            //        }
            //        pop();
            //        continue;
            //    }
            //    int a = (byte)peek();
            //    a = op.IndexOf((char)a);
            //    if (oncelik[a] >= oncelik[op.IndexOf(ch)])
            //    {
            //        postfix = postfix + (char)pop();
            //        push(ch);
            //    }
            //    else // yerine continue de denebilir
            //    {
            //        push(ch);
            //    }
            //}
            //while (peek() != (byte)'$')
            //{
            //    postfix = postfix + (char)pop();
            //}
            //Console.WriteLine(postfix);
            //Console.ReadLine();
            #endregion

            #region POSTFIX to RESULT

            string postfix = "ab*c+d-";
            // a=1,b=1,c=1,d=1
            string degisken = "";
            int[] vals = { 1, 1, 1, 1 };
            string op = "*/+-";

            for (int i = 0; i < postfix.Length; i++)
            {
                if (op.IndexOf(postfix[i]) == -1)
                {
                    if (degisken.IndexOf(postfix[i])==-1)                    
                        degisken = degisken + postfix[i];
                    int indis = degisken.IndexOf(postfix[i]);
                }             
            }
            
            for (int i = 0; i < postfix.Length; i++)
            {
                if (op.IndexOf(postfix[i]) == -1)
                {
                    // push(postfix[i]);
                    int indis = degisken.IndexOf(postfix[i]);
                    push(vals[indis]);
                    continue;
                }
                int opr1 = pop();
                int opr2 = pop();
                int sonuc = 0;

                if (postfix[i] == '*')
                    sonuc = carpim(opr1, opr2);

                if (postfix[i] == '/')
                    sonuc = bolum(opr2, opr1);

                if (postfix[i] == '+')
                    sonuc = toplam(opr1, opr2);

                if (postfix[i] == '-')
                    sonuc = fark(opr2, opr1);
                push(sonuc);
            }
            Console.WriteLine(pop());

            #endregion

            //// COMPILER DESIGN ARASTIR !!!
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// POSTFIX'ten INFIX'e donusturun (ODEV 1)
            /// POSTFIX ifadeden sonuc bulunmasi (ODEV 2)
            /// ODEVLERDE uslu ifade de kullanin 
            /// uzun degisken isimleri kullanin alan*yukseklik/iki gibi
            /// Optimize etmeye calis
            /// zeynep hoca mail adresi
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// abbcd*-/+
            /// STACK : a+(b/(b-(c*d))
        }
    }
}
