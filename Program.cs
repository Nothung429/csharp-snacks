// See https://aka.ms/new-console-template for more information

////Snack-1: l'utente inserisce due numeri in successione, il software stampa il maggiore
//Console.Write("Inserisci il primo numero:");
//int firstNumber = Convert.ToInt32(Console.ReadLine());
//Console.Write("Inserisci il secondo numero:");
//int secondNumber = Convert.ToInt32(Console.ReadLine());
//if (firstNumber > secondNumber)
//{
//    Console.WriteLine($"{firstNumber} è il maggiore");
//}
//else
//{
//    Console.WriteLine($"{secondNumber} è il maggiore");
//}

////Snack-2: l'utente inserisce due parole in successione, il software stampa prima la parole più corta, poi la parola più lunga
//Console.WriteLine("Inserisci la prima parola:");
//string firstWord = Console.ReadLine();
//char[] word1Letters = new char[firstWord.Length];
//Console.WriteLine("Inserisci la seconda parola:");
//string secondWord = Console.ReadLine();
//char[] word2Letters = new char[secondWord.Length];
//if (secondWord.Length < firstWord.Length)
//{
//    Console.WriteLine($"{secondWord} {firstWord}");
//}
//else
//{
//    Console.WriteLine($"{firstWord} {secondWord}");
//}

////Snack-3: il software deve chieder per 10 volte all'utente di inserire un numero, il software stampa la somma di tutti i numeri
//int number;
//int somma = 0;
//for (int i = 0; i < 10; i++)
//{
//    Console.Write("Inserisci un numero: ");
//    number = Convert.ToInt32(Console.ReadLine());
//    somma += number;
//}
//Console.Write($"La somma dei numeri é: {somma} ");

////Snack-4: calcola la somma è la media dei numeri da 2 a 10
//int somma = 0;
//float media;
//for (int i = 2; i <= 10; i++)
//{
//    somma += i;
//}
//media = somma / 9;
//Console.Write($"La somma dei numeri é: {somma} ");
//Console.Write($"La media dei numeri é: {media} ");

////Snack-5: il software chiede all'utente di inserire un numero, se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo
//Console.Write("Inserisci un numero: ");
//int number = Convert.ToInt32(Console.ReadLine());
//if (number % 2 == 0)
//{
//    Console.Write(number);
//}
//else
//{
//    Console.Write(number + 1);
//}

////Snack-6: in un array sono contenuti i nomi degli invitati alla festa del grande Gatsby, chiedi all'utente il suo nome e comunicagli se può partecipare o meno alla festa
//string[] invitati = { "mario", "paolo", "luca" };
//Console.Write("Inserisci il tuo nome:");
//string nomeUtente = Console.ReadLine();
//for (int i = 0; i < invitati.Length; i++)
//{
//    string invitato = invitati[i];
//    if (invitato == nomeUtente)
//    {
//        Console.WriteLine("BENVENUTO");
//        break;
//    }
//    else
//    {        
//        Console.WriteLine("QUI NON TI VOGLIAMO");
//        break;
//    }
//}

//Snack-7: crea un array vuoto, chiedi per sei volte all'utente di inserire un numero, se è dispari inseriscilo nell'array
//int number;
//int[] odd;
//for (int i = 0; i < 6; i++)
//{
//    Console.Write("\nInserisci un numero: ");
//    number = Convert.ToInt32(Console.ReadLine());
//    if (number % 2 == 0)
//    {
//        Console.Write("\n----pari----\n");
//    }
//    else
//    {
//        odd = new int[number];
//        Console.Write("\n----ok----\n");
//    }
//}

//Snack-8: crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari
//int[] oddPosition = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//int somma = 0;
//for (int i = 0; i < oddPosition.Length; i++)
//{
//    if (oddPosition[i] % 2 != 0)
//    {
//        somma += oddPosition[i];
//    }
//}
//Console.WriteLine($"La somma dei numeri in posizione dispari è: {somma}");

//Snack-9: crea un array vuoto e chiedi all'utente un numero da inserire nell'array, continua a chiedere numeri all'utente e a inserirli nell'array, fino a quando la somma degli elementi è minore di 50
//int number;
//int[] array;
//int somma = 0;

//while (somma < 50) {
//    Console.Write("\nInserisci un numero: ");
//    number = Convert.ToInt32(Console.ReadLine());
//    array = new int[number];
//    somma += number;
//    Console.Write(somma);
//}

//Snack-10: fai inserire un numero, che chiameremo N, all'utente, genera N array, ognuno formato da 10 numeri casuali tra 1 e 100, ogni volta che ne crei uno, stampalo a schermo
Console.Write("Inserisci un numero numero:");
int numberArray = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= numberArray; i++)
{
    int[] array;
    for (int j = 0; j < 10; j++)
    {
        Random rand = new Random();
        int number = rand.Next(0, 100);
        array = new int[number];
    }
}
