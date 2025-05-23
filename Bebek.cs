using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BebekKişi
{
    public class Bebek
    {
        public Bebek()
        {
            Console.WriteLine("Ingaaaaaaaaaa");

            Ad = "Belirsiz";
            Soyad = "Belirsiz";
            DoğumTarihi = DateTime.Now;
        }


        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DoğumTarihi { get; set; }

        // Parametreli Constructor
        public Bebek(string ad, string soyad, DateTime dateTime)
        {
            Ad = ad;
            Soyad = soyad;
            DoğumTarihi = DateTime.Now;
        }
    }
}


