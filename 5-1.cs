using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERI_YAPILARI_6
{
    internal class Program
    {
        class Block
        {
            public int data;
            public Block left;
            public Block right;
        }

        static int[] Tree = new int[100];

        static void Write(int[] btree, int i)
        {
            //if (i >= 15) return;
            //Console.WriteLine(btree[i]);
            //Write(btree, 2 * i + 1);
            //Write(btree, 2 * i + 2);
        }

        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////////////
            /// TREE - AGACLAR
            ////////////////////////////////////////////////////////////////////////
            /// Agaclar blocklar ve node'lardan olusur.
            /// Bir ve birden fazla deger barindirabilirler.
            /// Agaclar pointer yapilarinin guzel bir ornegidir.
            /// Bir block'da 'n' adet item varsa 'n+1' adet pointer vardir.
            /// En basit Tree yapida 1 adet item vardir. 
            /// En basit Tree yapisi = BINARY TREE
            /// Baslangic blogu LEVEL 0 = ROOT BLOCK veya ROOT NODE (KOK DUGUM)
            /// En alt blok seviyesi LEAF LEVEL
            /// Her level dolu ise BALANCED TREE (Dengeli Agac)
            /// Sol cocuk = 2n + 1
            /// Sag cocuk = 2n + 2
            /// OLMAYAN NODE'LAR ICIN COZUM URET
            ////////////////////////////////////////////////////////////////////////

            #region DIZI ILE IMPLEMENTE
            // LEVEL 0
            Tree[0] = 50;

            // LEVEL 1
            Tree[1] = 17;
            Tree[2] = 72;

            // LEVEL 2
            Tree[3] = 12;
            Tree[4] = 23;
            Tree[5] = 56;
            Tree[6] = 76;

            // LEVEL 3
            Tree[7] = 9;
            Tree[8] = 14;
            Tree[9] = 19;
            Tree[10] = -1; // olmadigini ifade etmek icin -1 datasi verildi
            Tree[11] = -1;
            Tree[12] = 67;
            Tree[13] = -1;
            Tree[14] = -1;

            //Write(Tree, 0);
            //Console.ReadLine();


            // Recursive olani While ile yaptik sinavda gelebilir
            Stack<int> st = new Stack<int>();
            st.Push(0);
            while (st.Count > 0)
            {
                int indis = st.Pop();
                Console.WriteLine(Tree[indis]);
                indis = indis * 2 + 1;
                if (indis <= 14) st.Push(indis);
                indis++;
                if (indis <= 14) st.Push(indis);
            }

            #endregion


        }
    }
}
