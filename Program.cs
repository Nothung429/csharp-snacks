// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Snack-1: l'utente inserisce due numeri in successione, il software stampa il maggiore
Console.Write("Inserisci il primo numero:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Inserisci il secondo numero:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber)
{
    Console.WriteLine($"{firstNumber} è il maggiore");
}
else
{
    Console.WriteLine($"{secondNumber} è il maggiore");
}

//Snack-2: l'utente inserisce due parole in successione, il software stampa prima la parole più corta, poi la parola più lunga
Console.WriteLine("Inserisci la prima parola:");
string firstWord = Console.ReadLine();
char[] word1Letters = new char[firstWord.Length];
Console.WriteLine("Inserisci la seconda parola:");
string secondWord = Console.ReadLine();
char[] word2Letters = new char[secondWord.Length];
if (secondWord.Length < firstWord.Length)
{
    Console.WriteLine($"{secondWord} {firstWord}");
}
else
{
    Console.WriteLine($"{firstWord} {secondWord}");
}