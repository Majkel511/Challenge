int[] grades = new int[365];

string[] dayOfWeeks0 = new string[7]; // Tworzenie tablic sposobem przypisaniem ilosci kolum do tabeli
dayOfWeeks0[0] = "Poniedziałek";
dayOfWeeks0[1] = "Wtorek";
dayOfWeeks0[2] = "Sroda";
dayOfWeeks0[3] = "Czwartek";
dayOfWeeks0[4] = "Piątke";
dayOfWeeks0[5] = "Sobota";
dayOfWeeks0[6] = "Niedziela";

for (int i = 0; i < dayOfWeeks0.Length; i++)
{
    Console.WriteLine(dayOfWeeks0[i]);
}

List<string> dayOfWeeks = new List<string>(); // **Tworzenie listy**
dayOfWeeks.Add("Monday");
dayOfWeeks.Add("Tuesday");
dayOfWeeks.Add("Wednesday");
dayOfWeeks.Add("Thursday");
dayOfWeeks.Add("Friday");
dayOfWeeks.Add("Saturday");
dayOfWeeks.Add("Sunday");

for (var i = 0; i < dayOfWeeks.Count; i++)  // Wyswietla liste dodajac do poprzedniego elementu +1
{
    Console.WriteLine(dayOfWeeks[i]);
}

foreach (var day in dayOfWeeks) //**Petla Foreach (Listy) Prostrzy sposob wyswietlenia listy**
{
    Console.WriteLine(day);
}