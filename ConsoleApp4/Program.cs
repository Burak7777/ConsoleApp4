
class Hayvanlar
{
    public void kosar()
    {
        Console.WriteLine("Hayvanlar koşar");
    }
}
class Atlar : Hayvanlar
{

}
class Katır : Hayvanlar
{
    public void yuktasır()
    {
        Console.WriteLine("Katırlar yük taşır");
    }
}

class YarısAtı : Hayvanlar
{
    public void yarısır()
    {
        Console.WriteLine("Yarış atları yarışır");
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Hayvanlar hayvan = new Hayvanlar();
        hayvan.kosar();
        Katır katır = new Katır();
        katır.yuktasır();
        YarısAtı yarısatı = new YarısAtı();
        yarısatı.yarısır();
    }
}


string ad = ("adı: burak ");
console.writeline(ad);

string soyad = ("soyadı: kenesarı ");
console.writeline(soyad);

string mesaj = $"bu kişinin {ad} {soyad}";
console.writeline(mesaj);

using System.Runtime.CompilerServices;

class ABC
{
    String adi;
    int boyut;
    String rengi;
    float fiyat;

    ABC(String adi, int boyut, String rengi, float fiyat)
    {
        this.adi = adi;
        this.boyut = boyut;
        this.rengi = rengi;
        this.fiyat = fiyat;
    }
    public static void Main()
    {
        ABC orn = new ABC("Araba", 4, "Mavi", (float)1000000.200);
        Console.WriteLine(" Ürün adı= " + orn.adi + " Ürün boyutu= " + orn.boyut + "Ürün rengi= " + orn.rengi + "Ürün fiyatı= " + orn.fiyat);
    }
}


class Matematiksel
{
    public void topla(int sayi1, int sayi2)
    { Console.WriteLine(sayi1 + sayi2); }

    public void carp(int sayi1, int sayi2)
    { Console.WriteLine(sayi1 * sayi2); }

    public void böl(int sayi1, int sayi2)
    { Console.WriteLine(sayi1 / sayi2); }

    public void cıkarma(int sayi1, int sayi2)
    { Console.WriteLine(sayi1 - sayi2); }
}

internal class Program
{
    static void Main(string[] args)
    {
        Matematiksel topla = new Matematiksel();
        topla.topla(10, 20);
        Matematiksel carp = new Matematiksel();
        carp.carp(10, 20);
        Matematiksel bolme = new Matematiksel();
        bolme.böl(10, 20);
        Matematiksel cıkarma = new Matematiksel();
        cıkarma.cıkarma(10, 20);
    }
}






































