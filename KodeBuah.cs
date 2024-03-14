using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302220131
{
	internal class KodeBuah
	{
		public String Namabuah;
		public String Kodebuah;
		public List<KodeBuah> KodebuahList = new List<KodeBuah>();
        public KodeBuah(String a = "", String k = "")
        {
            this.Namabuah = a;
            this.Kodebuah = k;
        }

        public void setKodeBuah()
		{
			this.KodebuahList.Add(new KodeBuah("Apel", "A00"));
            this.KodebuahList.Add(new KodeBuah("Aprikot", "B00"));
            this.KodebuahList.Add(new KodeBuah("Alpukat", "C00"));
            this.KodebuahList.Add(new KodeBuah("Pisang", "D00"));
            this.KodebuahList.Add(new KodeBuah("Paprika", "E00"));
            this.KodebuahList.Add(new KodeBuah("Blackberry", "F00"));
            this.KodebuahList.Add(new KodeBuah("Ceri", "H00"));
            this.KodebuahList.Add(new KodeBuah("Kelapa", "I00"));
            this.KodebuahList.Add(new KodeBuah("Jagung", "J00"));
        }

        public void getKodeBuah()
        {
            Console.WriteLine("Nama Buah\tKodeBuah");
            foreach (KodeBuah k in this.KodebuahList)
            {
                string kelPad = k.Namabuah.PadRight(15);
                Console.Write(kelPad + "\t" + k.Kodebuah);
                Console.WriteLine();
            }
        }
	}
}