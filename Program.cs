////Snack-1: l'utente inserisce due numeri in successione, il software stampa il maggiore

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

////Snack-2: l'utente inserisce due parole in successione, il software stampa prima la parolepiù corta, poi la parola più lunga

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

////Snack-3: il software deve chieder per 10 volte all'utente di inserire un numero, il software stampa la somma di tutti i numeri

    int number;
    int somma = 0;

    for (int i = 0; i < 10; i++)
    {
        Console.Write("Inserisci un numero: ");
        number = Convert.ToInt32(Console.ReadLine());
        somma += number;
    }

    Console.Write($"La somma dei numeri é: {somma} ");

////Snack-4: calcola la somma è la media dei numeri da 2 a 10

    int somma = 0;
    float media;

    for (int i = 2; i <= 10; i++)
    {
        somma += i;
    }
    media = somma / 9;

    Console.Write($"La somma dei numeri é: {somma} ");
    Console.Write($"La media dei numeri é: {media} ");

////Snack-5: il software chiede all'utente di inserire un numero, se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo

    Console.Write("Inserisci un numero: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number % 2 == 0)
    {
        Console.Write(number);
    }
    else
    {
        Console.Write(number + 1);
    }

////Snack-6: in un array sono contenuti i nomi degli invitati alla festa del grande Gatsby, chiedi all'utente il suo nome e comunicagli se può partecipare o meno alla festa

    string[] invitati = { "mario", "paolo", "luca" };
    Console.Write("Inserisci il tuo nome:");
    string nomeUtente = Console.ReadLine();

    for (int i = 0; i < invitati.Length; i++)
    {
        string invitato = invitati[i];
        if (invitato == nomeUtente)
        {
            Console.WriteLine("BENVENUTO");
            break;
        }
        else
        {
            Console.WriteLine("QUI NON TI VOGLIAMO");
            break;
        }
    }

////Snack-7: crea un array vuoto, chiedi per sei volte all'utente di inserire un numero, se è dispari inseriscilo nell'array

    int[] odd = new int[6];
    int pos = 0;

    for (int i = 0; i < odd.Length; i++)
    {
        Console.Write("\nInserisci un numero: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 != 0)
        {
            odd[pos] = number;
            pos++;
        }
    }

    for (int i = 0; i < odd.Length; i++)
    {
        if (odd[i] == 0)
        {
            break;
        }
        else
        {
            Console.WriteLine(odd[i]);
        }
    }

////Snack-8: crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari

    int[] oddPosition = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int somma = 0;

    for (int i = 0; i < oddPosition.Length; i++)
    {
        if (i % 2 != 0)
        {
            somma += oddPosition[i];
        }
    }

    Console.WriteLine($"La somma dei numeri in posizione dispari è: {somma}");

////Snack-9: crea un array vuoto e chiedi all'utente un numero da inserire nell'array, continua a chiedere numeri all'utente e a inserirli nell'array, fino a quando la somma degli elementi è minore di 50

    int[] arrayUndefined = new int[50];
    int i = 0;
    int somma = 0;

    while (somma < 50)
    {
        Console.Write("\nInserisci un numero: ");
        int number = Convert.ToInt32(Console.ReadLine());

        arrayUndefined[i] = number;
        somma += number;

        Console.Write(somma);
    }

////Snack-10: fai inserire un numero, che chiameremo N, all'utente, genera N array, ognuno formato da 10 numeri casuali tra 1 e 100, ogni volta che ne crei uno, stampalo a schermo

    Console.Write("Inserisci un numero numero:");
    int numberArray = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[numberArray];

    for (int i = 0; i <= numberArray; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            array[j] = new Random().Next(1, 100);
            Console.Write(array[j]);
        }
    }

//Snack-11: dare la possibilità di inserire due parole, verificare tramite una funzione che le due parole abbiano la stessa lunghezza, se hanno la stessa lunghezza, stamparle entrambe, altrimenti stampare la più lunga delle due

    string StringLength(string string1, string string2)
    {
        if (string1.Length == string2.Length)
        {
            Console.Write(string1);
            Console.Write(string2);
        }
        else if (string1.Length > string2.Length)
        {
            Console.Write(string1);
        }
        else
        {
            Console.Write(string2);
        }
        return string1;
        return string2;
    }

    Console.WriteLine("Inserisci la prima parola:");
    string firstWord = Console.ReadLine();
    Console.WriteLine("Inserisci la seconda parola:");
    string secondWord = Console.ReadLine();

    string verify = StringLength(firstWord, secondWord);

//Snack 12: scrivere una funzione per verificare se un numero è pari o dispari, quindi chiedere un numero all'utente e comunicargli se è pari o dispari

    int EvenOdd(int number)
    {
        if (number % 2 == 0)
        {
            Console.Write("PARI \n");
        }
        else
        {
            Console.Write("DISPARI \n");
        }
        return number;
    }

    Console.Write("Inserisci un numero: ");
    int userNumber = Convert.ToInt32(Console.ReadLine());

    int verify = EvenOdd(userNumber);