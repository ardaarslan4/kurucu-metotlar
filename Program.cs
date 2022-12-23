using System;

namespace kurucu_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Söz Dizimi
            // class SinifAdi
            {
                [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
                [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi (Parametre Listesi)
                {
                    Metot kKomutları
                }
            }*/

            /*Erişim Belirleyiciler
                *public
                *private
                *internal
                *protected
            */
            Console.WriteLine("*****Çalışan 1*****");
            Calisan calisan1 = new Calisan("Ayşe","Kara",23454321,"İnsan Kaynakları"); //kurucu metotta 4 tane parametre olduğu için buranın da içini bu parametrelerle dolduruyoruz
            /* bu işlemleri artık yukarıda kurucu metot sayesinde yapabildiğimiz için bunlara ihtiyaç kalmadı
            calisan1.Ad="Ayşe";
            calisan1.Soyad="Kara";
            calisan1.No=23454321;
            calisan1.Departman="İnsan Kaynakları";*/      
            calisan1.CalisanBilgileri();

            Console.WriteLine("*****Çalışan 2*****");
            Calisan calisan2 = new Calisan("Deniz","Arda",12345678,"Satın Alma");
            /* bu işlemleri artık yukarıda kurucu metot sayesinde yapabildiğimiz için bunlara ihtiyaç kalmadı
            calisan2.Ad="Deniz";
            calisan2.Soyad="Arda";
            calisan2.No=12345678;
            calisan2.Departman="Satın Alma";*/         
            calisan2.CalisanBilgileri();

            Console.WriteLine("*****Çalışan 3*****");
            Calisan calisan3= new Calisan("Zikriye","Ürkmez"); //Burada çalışan no 0, departman boş şekilde gelecek yazdırınca
            calisan3.CalisanBilgileri(); 
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad,string soyad, int no, string departman) //kurucu metodum bu benim, argümanları küçük harfle yazıyoruz.
        {
            this.Ad = ad; //bu sınıfın elemanı diyoruz yani
            this.Soyad=soyad;
            this.No=no;
            this.Departman=departman;

        }

        public Calisan(string ad, string soyad)//Overload ediyorum.
        {
            this.Ad = ad; //bu sınıfın elemanı diyoruz yani
            this.Soyad=soyad;
        } 

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0}", Ad);
            Console.WriteLine("Çalışan Soyadı:{0}", Soyad);
            Console.WriteLine("Çalışanın Numarası:{0}", No);
            Console.WriteLine("Çalışanın Departmanı:{0}", Departman);

        }
    }
}
