using System.Collections;
using CollectionSchulungÜbung1;

Person person = new Person();
ArrayList arrayList = new ArrayList();
arrayList.Add("Hallo Welt!");
arrayList.Add(145);
arrayList.Add(person);
Console.WriteLine("Liste wurde erstellt.");
int i = 1;
Console.WriteLine("Elemente in der Liste:");
foreach (var variable in arrayList)
{
    Console.Write(i + ". ");
    Console.WriteLine(variable);
    i++;
}

Console.WriteLine($"Es sind {arrayList.Count} Elemente in der ArrayList");
arrayList.Clear();
Console.WriteLine("Liste wurde gecleart.");