// See https://aka.ms/new-console-template for more information

Random k = new Random();
char karta;
do
{
    int card1 = k.Next(1, 10);
    int card2;
    Console.WriteLine("wylosowana liczba to " + card1);
    Console.WriteLine("następna liczba będzie (w)yższa czy (n)iższa");

    karta = Console.ReadKey(true).KeyChar;
    switch (karta)
    {
        case 'w':
            card2 = k.Next(1, 10);
            Console.WriteLine("Wylosowana liczba to " + card2);
            if (card2 > card1)
                Console.WriteLine("Gratulacje - wygrał*ś!");
            else
                Console.WriteLine("Niestety - przegrał*ś");
            break;
        case 'n':
            card2 = k.Next(1, 10);
            Console.WriteLine("Wylosowana liczba to " + card2);
            if (card2 < card1)
                Console.WriteLine("Gratulacje - wygrał*ś!");
            else
                Console.WriteLine("Niestety - przegrał*ś");
            break;
        default:
            Console.WriteLine("Podał*ś nieobsługiwaną odpowiedź - spróbuj ponownie");
            Console.WriteLine("Naciśnij (q) aby wyjść z gry");
            break;

    }
    Console.WriteLine();
} while (karta != 'q');