using ChallengeApp2;

namespace ChallengeApp2
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
        }

        public Statistick GetStatistick()
        {
            var statistick = new Statistick();

            statistick.Average = 0;
            statistick.Max = float.MinValue;
            statistick.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {

                statistick.Max = Math.Max(statistick.Max, grade);
                statistick.Min = Math.Min(statistick.Min, grade);
                statistick.Average += grade;

            }

            statistick.Average /= this.grades.Count;

            return statistick;

        }

    }
}
