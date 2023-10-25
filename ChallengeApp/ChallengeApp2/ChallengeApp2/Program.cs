using ChellengeApp2;

var user1 = new Employee("Adam", "Mickiewicz");
var user2 = new Employee("Fryderyk", "Chopin");
var user3 = new Employee("ludwig", "Beethoven");

user1.AddScore(5);
user1.AddScore(2);
user1.AddScore(8);
user1.AddScore(1);
user1.AddScore(9);
user1.AddScore(0);

user2.AddScore(8);
user2.AddScore(9);
user2.AddScore(9);
user2.AddScore(2);
user2.AddScore(5);

user3.AddScore(3);
user3.AddScore(4);
user3.AddScore(5);
user3.AddScore(6);
user3.AddScore(7);

List<Employee> employees = new List<Employee>()
{
    user1, user2, user3,
};

int maxResult = -1;
Employee employeeWithMaxResult = null;
foreach (Employee employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}
Console.WriteLine("Najlepszy pracownik pod katem punktowym to:");
Console.WriteLine(employeeWithMaxResult.Name + " " + $"{employeeWithMaxResult.Surname}:" + " " + $"{employeeWithMaxResult.Result} pts.");
Console.WriteLine("Brawo byle by tak dalej.:");
