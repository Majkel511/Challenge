var name = "Michal";
var gender = "Men";
var old = 33;

if (name == "Michal" && old == 33 && gender == "Men")
{
    Console.WriteLine("Michal, lat 33");
}
else if (old >= 34 && gender == "Men")
{
    Console.WriteLine("Meżczyzna starszy od 34 lat");
}
else if (old <= 32 && gender == "Men")
{
    Console.WriteLine("Meżczyzna młodszy od 32 lat");
}
else if (old < 32 && gender == "Woman")
{
    Console.WriteLine("Kobieta młodsza od 32 lat");
}
else if (old == 32 && gender == "Woman")
{
    Console.WriteLine("Kobieta w wieku 32 lat");
}
else if (old > 32 && gender == "Woman")
{
    Console.WriteLine("Kobieta starsza od 32 lat");
}
else
{
    Console.WriteLine("Warunek niespelniony ");
}