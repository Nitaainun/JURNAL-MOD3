using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JURNALMOD3_1202200019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KodeBuah table_KodeBuah = new KodeBuah();
            Console.WriteLine("Get Kode Buah Apel");
            table_KodeBuah.getKodeBuah("Apel");
            Console.WriteLine("Get all kode Buah");
            table_KodeBuah.getAllkodeBuah();

            Console.WriteLine("Kunci Pintu");
            PosisiKarakterGame posisi = new PosisiKarakterGame();
           

        }
    }
    class KodeBuah
    {
        Dictionary<string, string> dic = new Dictionary<string, string>() {
            {"Apel", "A00"},
            {"Aprikot","B00" },
            {"Alpukat"  ,"C00" },
            {"Pisang"    ,"D00" },
            {"Paprika"  ,"E00"},
            {"Blackberry" ,"F00" },
            {"Ceri","H00"},
            {"Kelapa" ,"I00" },
            {"Jagung","J00"},
            {"Kurma"   ,"K00"},
            {"Durian"   ,"L00"},
            {"Anggur", "M00" },
            {"Melon", "N00" },
            {"Semangka", "O00" } };

        public void getKodeBuah(string kel)
        {
            if (dic.ContainsKey(kel))
            {
                Console.WriteLine(kel + " : " + dic[kel]);
            }
            else
            {
                Console.WriteLine(kel + " tidak ditemukan");
            }
        }

        public void getAllkodeBuah()
        {
            foreach (KeyValuePair<string, string> ele1 in dic)
            {
                Console.WriteLine("{0} \t\t {1}", ele1.Key, ele1.Value);
            }
        }
    }

    class PosisiKarakterGame
    {
        enum state {Jongkok, Berdiri, Tengkurap, Terbang};
        public void main()
        {
            state state = state.Berdiri;
            string[] posisiName = { "Berdiri", "Terbang", "Jongkok", "Tengkurap" };
            while (State != state.Tengkurap)
            {
                Console.WriteLine(posisiName[(string)state] + "Posisi");
                Console.Write("Posisi : ");
                string command = Console.ReadLine();
                switch (state)
                {
                    case state.Berdiri:
                        if (command == "TombolW")
                            state = state.Terbang + ("Tombol arah atas ditekan");
                        else if (command == "TombolS")
                            state = state.Berdiri + ("Tombol arah bawah ditekan");
                        else if (command == "TombolS")
                            state = state.Tengkurap;
                        else (command == "TombolW")
                        break;
                }
            }
        }

    }

}

