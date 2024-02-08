using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkAround
{
  internal class Program
  {
    static void Main(string[] args)
    {
      #region Değişken
      //---------Değişkenler---------
      //string mesaj = "Salih Bey";
      //double tutar = 10000;
      //int sayi = 10;
      //bool girisYapilmisMi=false;
      #endregion

      Vatandas vatandas1 = new Vatandas(); //instance (bir adet vatandaş oluşturduk)

      SelamVer();


      Person person1 = new Person();
      person1.FirstName = "SALİH";
      person1.LastName = "KÜÇÜK";
      person1.DateOfBirthYear = 1998;
      person1.NationalIdentity = 1111111111;


      PttManager pttManager = new PttManager(new PersonManager());
      pttManager.GiveMask(person1);

      Console.ReadLine();


      #region
      //---------------------//
      //Diziler-Arrays

      //string ogrenci1 = "Salih";
      //string ogrenci2 = "GFFFFFFFF";  //sıkıntılı olan bu şekilde tanımlamaktır.
      //string ogrenci3 = "XDF";       // Ddoğrusu aşağıdaki gibi tanımlamadır.


      //string[] ogrenciler = new string[3];   //3 elemanlı dizi tanımladık.
      //ogrenciler[0] = "Engin";
      //ogrenciler[1] = "Salih";
      //ogrenciler[2] = "xlarge";

      //ogrenciler = new string[4];
      //ogrenciler[3] = "İlker";  //stack ve heap konusu.
      //                          //bu kısımla çalışırken yalnızca İlker yazılır. İlk 3 öğe yazılmaz.


      //for (int i = 0; i < ogrenciler.Length; i++)
      //{
      //    Console.WriteLine(ogrenciler[i]);
      //}


      string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
      string[] sehirler2 = new[] { "Tokat", "Erbaa", "Kadıköy" };

      foreach (string sehir in sehirler1)
      {
        Console.WriteLine(sehir);
      }

      int[] sayilar = new int[] { 1, 2, 3, 4 };

      foreach (int sayi in sayilar) // hangi tipte ise dizi onu verip sayi kısmına istediğimizi yazabiliriz. Takma isimdir. 
      {
        Console.WriteLine(sayi);
      }



      // --Kullanım bu şekilde ilerliyor-- //
      List<string> yenisehirler1 = new List<string> { "Ankara 33", "33 İstanbul", " 66 İzmir" };
      yenisehirler1.Add("Tokat 60");

      foreach (var sehirler in yenisehirler1)
      {
        Console.WriteLine(sehirler);
      }

      #endregion


      Toplama();
    }

    static void SelamVer(string isim = "İsimsiz") //yukarda selamver() içerisi boş bırakılır yani parametre verilmezse isimsiz yazacaktır.
    {
      Console.WriteLine("Merhaba " + isim);
    }



    static int Toplama(int sayi1 = 55, int sayi2 = 61) //yukarda toplama() içerisi boş bırakılır yani parametre verilmezse 55+61 işlem sonucu yazacaktır.
    {
      int sonuc = sayi1 + sayi2;
      Console.WriteLine("Toplam " + sonuc);
      return sonuc;
    }

    //void metotlar sadece işi yapar. Emir kipiyle çalışır.
    public class Vatandas
    {  //Kelimelerin ilk harfi büyük pascal case
      public string Ad { get; set; }
      public string Soyad { get; set; }
      public int DogumYili { get; set; }
      public short TcNo { get; set; }
    }
  }
}
