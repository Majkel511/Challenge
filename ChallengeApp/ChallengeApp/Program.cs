// Przygotuj program, ktory policzy ile jakich cyfr
// występuje w podanej liczbie:

// Przydkład:
// Wynik dla liczby: 4566
// 0 => 0
// 1 => 0
// 2 => 0
// 3 => 0
// 4 => 1
// 5 => 1
// 6 => 2
// 7 => 0
// 8 => 0
// 9 => 0


int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

var container0 = 0;
var container1 = 0;
var container2 = 0;
var container3 = 0;
var container4 = 0;
var container5 = 0;
var container6 = 0;
var container7 = 0;
var container8 = 0;
var container9 = 0;

foreach (char letter in letters)
{
    if (letter == 0)
    {
        container0++;
    }
    else if (letter == '1')
    {
        container1++;
    }
    else if (letter == '2')
    {
        container2++;
    }
    else if (letter == '3')
    {
        container3++;
    }
    else if (letter == '4')
    {
        container4++;
    }
    else if (letter == '5')
    {
        container5++;
    }
    else if (letter == '6')
    {
        container6++;
    }
    else if (letter == '7')
    {
        container7++;
    }
    else if (letter == '8')
    {
        container8++;
    }
    else if (letter == '9')
    {
        container9++;
    }

}
Console.WriteLine("Twoja liczba do rozbicia to " + number + ".");
Console.WriteLine("Ile Pojawia sie cyfrt 0:" + container0);
Console.WriteLine("Ile Pojawia sie cyfrt 1:" + container1);
Console.WriteLine("Ile Pojawia sie cyfrt 2:" + container2);
Console.WriteLine("Ile Pojawia sie cyfrt 3:" + container3);
Console.WriteLine("Ile Pojawia sie cyfrt 4:" + container4);
Console.WriteLine("Ile Pojawia sie cyfrt 5:" + container5);
Console.WriteLine("Ile Pojawia sie cyfrt 6:" + container6);
Console.WriteLine("Ile Pojawia sie cyfrt 7:" + container7);
Console.WriteLine("Ile Pojawia sie cyfrt 8:" + container8);
Console.WriteLine("Ile Pojawia sie cyfrt 9:" + container9);