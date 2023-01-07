using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VERI_YAPILARI_7
{
    internal class Program
    {
        class Block
        {
            public int data;
            public Block next;
            public Block prev;
        }
        /*static int[] btree = { 50, 17, 72, 12, 23, 54, 76, 9, 14, -1, -1, 67, -1, -1 };
        static int[] btreeCheck = new int[100];
        static blockbtree headbtree = null;
        class blockbtree
        {
            public int data;
            public blockbtree left;
            public blockbtree right;
        }
        static void yaz(int[] btree, int i)
        {
            if (i > btree.Length) return;
            Console.WriteLine(btree[i]);
            yaz(btree, i * 2 + 1);
            yaz(btree, i * 2 + 2);
        }
        static bool bulundu = false;
        static void bul1(int[] btree, int i)
        {
            if (i >= btree.Length) return;
            if (btree[i] == 76) bulundu = true;
            bul1(btree, i * 2 + 1);
            bul1(btree, i * 2 + 2);
        }
        static int bul2(int[] btree, int i)
        {
            if (i >= btree.Length) return 0;
            if (btree[i] == 76) return 1;
            return bul2(btree, i * 2 + 1);
            return bul2(btree, i * 2 + 2);
        }
        static int bul3(int[] btree, int i, int aranan)
        {
            if (i >= btree.Length) return 0;
            if (btree[i] == aranan) return 1;
            if (btree[i] < aranan)
                return bul3(btree, i * 2 + 2, aranan);
            else
                return bul3(btree, i * 2 + 1, aranan);
        }

        // LINKED LIST ILE OLUSTURMAK
        static blockbtree olustur(int[] btree, int i)
        {
            if (i > btree.Length) return null;
            blockbtree bt = new blockbtree();
            bt.data = btree[i];
            bt.left = olustur(btree, i * 2 + 1);
            bt.right = olustur(btree, i * 2 + 2);
            return bt;
        }
        static int abcd = 0;
        static int bul4(blockbtree btree, int aranan)
        {
            if (btree == null) return 0;
            if (btree.data == aranan) return 1;
            if (btree.data < aranan)
                return bul4(btree.right, aranan);
            else
                return bul4(btree.left, aranan);
        }

        // AGACA YENI ELEMAN EKLEME
        static void ekle(blockbtree btree, int data)
        {
            if (btree.data < data)
            {
                if (btree.right != null) ekle(btree.right, data);
            }
            else
            {
                blockbtree bt = new blockbtree();
                bt.data = data;
                bt.left = null;
                bt.right = null;
                btree.left = bt;
            }
        }*/
        static int[] hash = new int[100];
        static Block[] coll = new Block[100];
        static void delete(int data)
        {
            int indis = hashing(data);
            if (hash[indis] == data)
            {
                if (coll[indis] != null)
                {
                    hash[indis] = coll[indis].data;
                    coll[indis] = coll[indis].next;
                }
                else hash[indis] = 0;
            }
            else
            {
                // BURAYI KENDIN YAP
            }
            // Yoksa linked list ile search ve delete et
        }
        static int hashing(int data)
        {
            data = data - 213205001;
            data = data % 100;
            return data;
        }
        static void ekle(int data)
        {
            int indis = hashing(data);
            if (hash[indis] == 0)
                hash[indis] = data;
            else
            {
                // NORMAL COZUM
                /*for (int i = 0; i < hash.Length; i++)
                {
                    if (hash[i] == 0)
                        hash[i] = data;
                    break;
                }*/

                // LINKED LIST
                Block bl = new Block();
                bl.data = data;
                bl.next = coll[indis];
                coll[indis] = bl;
                

            }
        }
        static int search(int data)
        {
            int indis = hashing(data);
            int bulundu = 0;
            if (hash[indis] == data) return 1;
            else
            {
                // NORMAL COZUM
                /*for (int i = 0; i < hash.Length; i++)
                {
                    if (hash[i] == data)
                        bulundu = 1;
                    break;                
                }*/

                // LINKED LIST
                Block temp = coll[indis];
                while(temp != null)
                {
                    if(temp.data == data)
                    {
                        bulundu = 1;
                        break;
                    }
                    temp = temp.next;
                }


            }
            return bulundu;
        }
        static void Main(string[] args)
        {
            /*Stack<int> st = new Stack<int>();
            st.Push(0);
            int bulundu = 0;
            while (st.Count > 0)
            {
                int indis = st.Pop();
                Console.WriteLine(btree[indis]);
                // '76' agacta mevcut mu ?
                if (btree[indis] == 76)
                    bulundu = 1; break;
                indis = indis * 2 + 1;
                if (indis < btree.Length) st.Push(indis); // Burada bi eksiklik var
                indis++;
                if (indis < btree.Length) st.Push(indis);
            }*/

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// BINARY SEARCH TREE
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// Sol tarafta kucuk, sag tarafta buyuk elemanlarin bulundugu agactir,
            /// Arama yapmayi kolaylastirir.
            /// Ikili arama sirali bir listede ortalayarak gider.
            /// Log2(n) = ln(n) daha maaliyetlidir. Taban her zaman 2'dir.
            /// Linked list olusturulmus ve binary tree var. Ilk blok head = 50. Bu yapiyi diziye aktaralim.
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// HASHING
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// Seach yapisidir.
            /// Key:Value olarak calisir.
            /// Key olarak INT ve Value olarak STRING kullanilir.
            /// dictionary<int,string> key,value degeri yazilir.
            /// Eger veriler dizilere yazilip aranan degerlerin indisi biliniyorsa cok yuksek performaslidir.
            /// Hash Function = diziler uzerine kurulmustur. Linked listlerde kullanilamaz.
            /// En hizli arama algoritmasidir
            /// Genelde kucuk boyutlu verilerde kullanilir
            /// Dizi boyutundan bagimsiz bir sekilde dizinin bir elemanina ulasmak cok hizlidir
            /// Aramam yapilacak veri ne olursa olsun veri indise donusturulmelidir.
            /// Veri --> Sayi (HASH FUNCTION)
            /// Verileri indise dagitirken dengeli degitilmalidir.
            /// Collision Probleminin onune gecmek icin MOD yapisi kullanilmalidir. (%)
            /// Ogrenci numaralari 213205004 - 213205005 - 213205006 gibi olsun

            ekle(213205005);
            ekle(213205105);
            ekle(213205205);
            if (search(213205005) == 1) Console.WriteLine("bulundu");
            else Console.WriteLine("bulunamadi");
            if (search(213205105) == 1) Console.WriteLine("bulundu");
            else Console.WriteLine("bulunamadi");
            if (search(213205205) == 1) Console.WriteLine("bulundu");
            else Console.WriteLine("bulunamadi");
            Console.ReadLine();
        }
    }
}
