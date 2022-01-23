// See https://aka.ms/new-console-template for more information

using MyDictionary;

Console.WriteLine("---------------------STANDARD DICTIONARY--------------------------------");


Dictionary<int,string> sehirler = new Dictionary<int,string>();

sehirler.Add(1, "Ankara");
sehirler.Add(2, "İstanbul");
sehirler.Add(3, "İzmir");
sehirler.Add(4, "Kahraman Maraş");


foreach (var item in sehirler)
{
    
    Console.WriteLine(item.Key+" "+item.Value);
}

Console.WriteLine(sehirler.Count);

Console.WriteLine("--------------------------MY DICTIONARY---------------------------------");


MyDictionary<int, string> cities = new MyDictionary<int, string>();

cities.Add(1, "Ankara");
cities.Add(2, "İstanbul");
cities.Add(3, "İstanbul");
cities.Add(4, "İstanbul");
cities.Add(5, "İstanbul");

Console.WriteLine(cities.CountKey);
Console.WriteLine(cities.CountValue);




