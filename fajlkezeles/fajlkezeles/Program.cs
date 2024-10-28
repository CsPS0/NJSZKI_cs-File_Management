#region Files
string file_adatok = "adatok.txt";
StreamReader adatok = new StreamReader(file_adatok)!;

string file_atlag = "atlag.txt";
StreamReader atlag = new StreamReader(file_atlag)!;

string file_doli = "doli.txt";
StreamReader doli = new StreamReader(file_doli)!;

string file_gyorshajtas = "gyorshajtas.txt";
StreamReader gyorshajtas = new StreamReader(file_gyorshajtas)!;

string file_szamok = "szamok1.txt";
StreamReader szamok = new StreamReader(file_szamok)!;
#endregion

#region 1.Feladat|doli

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("1.Feladat|doli:");
Console.ResetColor();

//Egyesek:

string[] nevek = new string[40];
int[] pontok = new int[40];
int index = 0;

while (!doli.EndOfStream && index < 40)
{
    nevek[index] = doli.ReadLine();
    pontok[index] = int.Parse(doli.ReadLine());
    index++;
}
doli.Close();

int egyesek = 0;

for (int i = 0; i < pontok.Length; i++)
{
    if (pontok[i] < 35) egyesek++;
}
Console.WriteLine($"Összesen {egyesek} írtak egyest.");

//Átlag:

double atlagf = 0;
double osszes = 0;
for (int i = 0; i < pontok.Length; i++)
{
    osszes += pontok[i];
}
atlagf = Math.Round(osszes / index, 1);
Console.WriteLine($"A csodálatos dolgozatok átlaga: {atlagf}");

//Legjobb Dolgozat:

int max = 0;
string nev = "";


#endregion

#region pause
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Nyomj entert a továbblépéshez!");
while (Console.ReadKey().Key != ConsoleKey.Enter)
{

}
Thread.Sleep(3000);

Console.ResetColor();
#endregion

#region 2.Feladat|adatok

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("2.Feladat|adatok:");
Console.ResetColor();

//Átlag:



//Leghosszabb név:



//? Diák = 50pont

#endregion

#region pause
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Nyomj entert a továbblépéshez!");
while (Console.ReadKey().Key != ConsoleKey.Enter)
{

}
Console.ResetColor();
#endregion

#region 3.Feladat|gyorshajtas

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("3.Feladat|gyorshajtás:");
Console.ResetColor();

//? Autó adatok:



//? Jármű leggyorsabb




//? Hányan x>50 KM/h + rendszam

#endregion