using ChallengeApp2;

var employee = new Employee("Michał", "Garncarz");

employee.AddGrade(2);
employee.AddGrade(5);
employee.AddGrade(9);

var statistick = employee.GetStatistick();

Console.WriteLine($"Average: {statistick.Average:N2}");
Console.WriteLine($"Min: {statistick.Min}");
Console.WriteLine($"Max: {statistick.Max}");

