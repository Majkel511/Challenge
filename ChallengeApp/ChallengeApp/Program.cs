var name = "Michal";
var gender = "Men";
var old = 33;

if (name == "Michal" && old == 33 && gender == "Men")
{
    Console.WriteLine("Jestes mężczyzna o imieniu Michal i masz 33 lata");
}
    else if (name == "Michal" && old >= 34)
    {
    Console.WriteLine("Michal masz wiecej lat niz 34");
    }

    else if (name == "Michal" && old <= 32)
    {
    Console.WriteLine("Michal masz mniej lat niz 32");
    }

else
{
    Console.WriteLine("Warunek niespelniony ");
}