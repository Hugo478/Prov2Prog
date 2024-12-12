using System.Linq.Expressions;

while (true)
{
    
    Console.WriteLine("Hur många bilar ska skapas? ");
Console.WriteLine("Skriv 0 för att avsluta programmet");
    string SkapaSvar =  Console.ReadLine();
    int IntSvar = int.Parse(SkapaSvar);
    
    if (IntSvar >= 1)
    {
        Console.WriteLine($"Du har skapat "+IntSvar+" bilar");
        List<int> Bilar;
    }
    if (IntSvar == 0)
    {
        return;
    }
    else 
    {
        Console.WriteLine("Skriv hur många i bilar som skapas med siffror (mer än 0) ");
    }
}