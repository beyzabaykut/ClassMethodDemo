using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---MÜŞTERİ TAKİBİ---");

            Customer customer1 = new Customer();
            customer1.Ad = "Süeda";
            customer1.SoyAd = "Yılmaz";
            customer1.Yas = 45;

            Customer customer2 = new Customer();
            customer2.Ad = "Hüsnü";
            customer2.SoyAd = "Kocaoğu";
            customer2.Yas = 50;

            Customer customer3 = new Customer();
            customer3.Ad = "Uğur";
            customer3.SoyAd = "Hünal";
            customer3.Yas = 26;

            Customer customer4 = new Customer();
            customer4.Ad = "Şemsi";
            customer4.SoyAd = "Turan";
            customer4.Yas = 32;

            Console.WriteLine("MÜŞTERİ LİSTESİ");
            Customer[] customer = new Customer[] {customer1,customer2,customer3,customer4 };
            foreach (Customer cust in customer)
            {
                Console.WriteLine(cust.Id);
                Console.WriteLine("Müşteri Ad:"+cust.Ad);
                Console.WriteLine("Müşteri Soyad:"+cust.SoyAd);
                Console.WriteLine("Müşteri Yaş:"+cust.Yas);
            }
            Console.WriteLine("----------------");

            CustomerManager customerManager = new CustomerManager();
            customerManager.MusteriEkle(customer1);
            customerManager.MusteriCikar(customer4);
            customerManager.YeniMusteriListesi(customer);




        }
    }
}
