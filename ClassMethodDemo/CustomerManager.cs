using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void MusteriEkle(Customer musteri)
        {
            Console.WriteLine("Müşteri Eklendi"+":"+ musteri.Ad+" "+ musteri.SoyAd);
        }
        public void MusteriCikar(Customer musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.SoyAd + " " + "Kişisi Listeden Çıkarılmıştır");
        }
        public void YeniMusteriListesi(Customer[] customers)
        {
            Console.WriteLine("Yeni Liste");
            foreach (var must in customers)
            {
                Console.WriteLine(must.Id);
                Console.WriteLine("Müşteri Ad:" + must.Ad);
                Console.WriteLine("Müşteri Soyad:" + must.SoyAd);
                Console.WriteLine("Müşteri Yaş:" + must.Yas);
            }
        }
    }
}
