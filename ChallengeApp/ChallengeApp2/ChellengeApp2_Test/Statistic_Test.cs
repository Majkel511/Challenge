using ChallengeApp2;
using ChellengeApp2_Test;

namespace ChellengeApp2_Test
{
    public class Tests
    {
        [Test]
        public void TestStatisticMin()
        {
            var employee = new Employee("Michal", "Garncarz");
            employee.AddGrade(1);
            employee.AddGrade(9);
            employee.AddGrade(2);
            employee.AddGrade(3);

            var statistick = employee.GetStatistick();

            Assert.AreEqual(1, statistick.Min);
        }

        [Test]
        public void TestStatisticAverage()
        {
            var employee = new Employee("Michal", "Garncarz");
            employee.AddGrade(1);
            employee.AddGrade(9);
            employee.AddGrade(2);
            employee.AddGrade(3);

            var statistick2 = employee.GetStatistick();

            Assert.AreEqual(3.75, statistick2.Average);
        }

        [Test]
        public void TestStatisticMax()
        {
            var employee = new Employee("Michal", "Garncarz");
            employee.AddGrade(1);
            employee.AddGrade(9);
            employee.AddGrade(2);
            employee.AddGrade(3);

            var statistick = employee.GetStatistick();

            Assert.AreEqual(9, statistick.Max);
        }
    }
}