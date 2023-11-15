using ConsoleAppHotelLift;
using System.ComponentModel;
using System.Threading.Channels;

List<Lift> list = File.ReadAllLines("lift.txt").Select(x => new Lift(x)).ToList();

Console.WriteLine("3. feladat");
Console.WriteLine($"\tÖsszes használat: {list.Count}");

Console.WriteLine("4. feladat");
//Console.WriteLine($"Időszak: {list.MinBy(x => x.Idopont).Idopont} - {list.MaxBy(x => x.Idopont).Idopont}");
//Console.WriteLine($"\tIdőszak: {list.OrderBy(x => x.Idopont).First().Idopont} - {list.OrderBy(x => x.Idopont).Last().Idopont}");
//DateTime startIdo = list.OrderBy(x => x.Idopont).First().Idopont;
//DateTime endIdo = list.OrderBy(x => x.Idopont).Last().Idopont;
//Console.WriteLine($"Időszak: {startIdo.Year}. {startIdo.Month}. {startIdo.Day}");
Console.WriteLine($"\tIdőszak: {list.MinBy(x => x.Idopont)?.Idopont.ToShortDateString()} - {list.MinBy(x => x.Idopont)?.Idopont.ToShortDateString()}");

Console.WriteLine("5. feladat");
//Console.WriteLine($"Célszint max: {list.MaxBy(x => x.CelSzint).CelSzint}");
Console.WriteLine($"\tCélszint max: {list.OrderBy(x => x.CelSzint).Last().CelSzint}");

Console.WriteLine("6-7. feladat");

int inputKartyaSzam;
int inputCelszint;

try
{
    Console.Write("Adja meg a kartyaszamot: ");
    inputKartyaSzam = Convert.ToInt32(Console.ReadLine());
    
}
catch (FormatException)
{
    inputKartyaSzam = 5;
}
try
{
    Console.Write("Adja meg a celszintet: ");
    inputCelszint = Convert.ToInt32(Console.ReadLine());
}
catch (FormatException)
{
    inputCelszint = 5;
}

Console.WriteLine($"\tKártyaszám: {inputKartyaSzam}");
Console.WriteLine($"\tCélszint: {inputCelszint}");

Console.WriteLine(list.Any(x => x.KartyaSzam == inputKartyaSzam && x.CelSzint == inputCelszint) ? 
    $"\tA {inputKartyaSzam}. kártyával utaztak a {inputCelszint}. szitnre!" : 
    $"\tA {inputKartyaSzam}. kártyával nem utaztak a {inputCelszint}. szintre!");

Console.WriteLine("8. feladat");

try
{

    File.WriteAllLines("liftWRITE.txt", list.GroupBy(x => x.Idopont).Select(x => $"\t{x.Key} - {x.Count()}x"));
    Console.WriteLine("\tSikeres fájlba írás!");

}
catch (Exception)
{

    throw new Exception("\tHibás volt az írás vagy a linQ!!");
}
