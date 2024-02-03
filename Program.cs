int[] sayilar = { 12, 24, 1, 99, 15, 21, 56 };

Console.WriteLine("****** Normal Gösterim *******");
foreach (var item in sayilar)
    Console.WriteLine(item);

Console.WriteLine("****** Sıralı Gösterim *******");
Array.Sort(sayilar);
foreach (var item in sayilar)
    Console.WriteLine(item);
Console.WriteLine("****** Ters Sıralı Gösterim *******");
Array.Reverse(sayilar);
foreach (var item in sayilar)
    Console.WriteLine(item);
Console.WriteLine("****** Clear Gösterim *******");
Array.Clear(sayilar,2,2);
foreach (var item in sayilar)
    Console.WriteLine(item);
Console.WriteLine("****** Indexof Gösterim *******");

    Console.WriteLine(Array.IndexOf(sayilar, 99));

Console.WriteLine("****** Resize Gösterim *******");
Array.Resize<int>(ref sayilar,3);
foreach (var item in sayilar)
    Console.WriteLine(item);
