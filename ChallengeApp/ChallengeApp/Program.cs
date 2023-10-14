var name = "Ewa";
var gender = "Woman";
var old = 33;

if (name == "Ewa" && gender == "Woman" && old == 33)
{
    Console.WriteLine("Ewa,lat 33");
    }
else if (gender == "Women" && old < 30)
{
    Console.WriteLine("Kobieta ponizej 30lat");
}
else if (gender == "Men" && old < 18)
{
    Console.WriteLine("Nepełnoleti Mężczyzna");
}
else
{
    Console.WriteLine("Niepoprawene dane");
}