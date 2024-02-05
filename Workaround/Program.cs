// See https://aka.ms/new-console-template for more information


//string message = "selam";
//double price = 61000;
//int number = 61;
//bool isAuthenticated = false;


//string name = "Furkan";
//string surname = "Sarmısak";
//int birthday = 1996;
//long tcId = 12345678987;

//Console.WriteLine(message);
using Business.Concrete;
using Entities.Concrete;
Person person1 = new Person();
person1.FirstName = "Furkan";
person1.LastName = "Sarmısak";
person1.DateofBirthYear = 1996;
person1.NationalIdentity = 123456789;
Person person2 = new Person();
person2.FirstName = "Nisa";

Person person3 = new Person();
person3.FirstName = "Ömer";

SelamVer(person1.FirstName);
SelamVer(person2.FirstName);
SelamVer(person3.FirstName);
SelamVer();
Topla(5, 7);
string student1 = "Furkan";
string student2 = "Nisa";
string student3 = "Ömer";

string[] ogrenciler = new string[3];
ogrenciler[0] = student1;
ogrenciler[1] = student2;
ogrenciler[2] = student3;

ogrenciler = new string[4];
ogrenciler[3] = "Özge";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}
string[] sehirler1 = new[] { "Ankara", "İstanbul", "Trabzon" };
string[] sehirler2 = new[] { "Bursa", "İzmir", "Antalya" };
sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);



foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

List<string> yeniSehirler1 = new List<string> { "Ankara", "İzmir", "Trabzon" };
yeniSehirler1.Add(sehirler2[1]);

foreach (var yeniSehir in yeniSehirler1)
{
    Console.WriteLine(yeniSehir);
}

PttManager pttManager = new PttManager(new personManager());
pttManager.GiveMask(person1);
static void SelamVer(string name = "İsimsiz")
{

    Console.WriteLine("Merhaba " + name);
}
static int Topla(int number1, int number2)
{
    int sonuc = number1 + number2;
    Console.WriteLine("Toplam:" + sonuc);
    return sonuc;
}


