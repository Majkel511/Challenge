namespace ChallengeApp.Test
{    public class Tests
    {
        [Test]
        public void WhenEmplyeeCollectTwoScores_ShouldCorrectResult()
        {
            //arrange
            var employee = new Employee("Adam", "Mickiewicz");

            Employee.AddScore(5);
            Employee.AddScore(2);

            //act
            var result = Employee.Equals;

            //assert
            Assert.AreEqual(25, result);

        }
    }
}