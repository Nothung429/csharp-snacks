// See https://aka.ms/new-console-template for more information

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

//Snack-3: il software deve chieder per 10 volte all'utente di inserire un numero, il software stampa la somma di tutti i numeri
int number;
int somma = 0;
for (int i = 0; i < 10; i++)
{
    Console.Write("Inserisci un numero: ");
    number = Convert.ToInt32(Console.ReadLine());
    somma += number;
}
Console.Write($"La somma dei numeri é: {somma} ");

//Snack-4: calcola la somma è la media dei numeri da 2 a 10
int somma = 0;
float media;
for (int i = 2; i <= 10; i++)
{
    somma += i;
}
media = somma / 9;
Console.Write($"La somma dei numeri é: {somma} ");
Console.Write($"La media dei numeri é: {media} ");