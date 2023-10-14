var name = "Ewa";
var gender = "Woman";
var age = 33;

if (name == "Ewa" && gender == "Woman" && age == 33)
{
    Console.WriteLine("Ewa,lat 33");
    }
else if (gender == "Women" && age < 30)
{
    Console.WriteLine("Kobieta ponizej 30lat");
}
else if (gender == "Men" && age < 18)
{
    Console.WriteLine("Nepełnoleti Mężczyzna");
}
else
{
    Console.WriteLine("Niepoprawene dane");
}