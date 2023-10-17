using ChallengeApp;

Employee user1 = new Employee("Adam", "Mickiewicz", 57);
Employee user2 = new Employee("Fryderyk", "Chopin", 39);
Employee user3 = new Employee("ludwig", "Beethoven", 57);

List<Employee> employees = new List<Employee>()
{
    user1, user2, user3
};

user1.AddGrade(5);
user1.AddGrade(2);
user1.AddGrade(8);
user1.AddGrade(1);
user1.AddGrade(9);
user1.AddGrade(0);

user2.AddGrade(8);
user2.AddGrade(9);
user2.AddGrade(9);
user2.AddGrade(2);
user2.AddGrade(5);

user3.AddGrade(3);
user3.AddGrade(4);
user3.AddGrade(5);
user3.AddGrade(6);
user3.AddGrade(7);

int maxResult = -1;
Employee employeeWithMaxResult = null;
foreach (Employee employee in employees)
{
    if (employee.Score > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Score;
    }
}
Console.WriteLine("Najlepszy pracownik pod katem punktowym to:");
Console.WriteLine(employeeWithMaxResult.Name + " " + $"{employeeWithMaxResult.Surname}:" +  " " + $"{employeeWithMaxResult.Score} pts.");
Console.WriteLine("Brawo byle by tak dalej.:");