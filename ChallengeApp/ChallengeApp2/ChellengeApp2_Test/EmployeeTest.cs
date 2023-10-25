using ChellengeApp2;


namespace ChellengeApp2_Test
{
    public class Tests
    {

        [Test]
        public void WhenStudentCollectScores()
        {
            var user = new Employee("Michal", "Garncarz");
            user.AddScore(5);
            user.AddScore(2);

            var result = user.Result;

            Assert.AreEqual(7, result);
        }

        public void WhenStudentCollectScores2()
        {
            var user = new Employee("Michal", "Garncarz");
            user.AddScore(-5);
            user.AddScore(2);

            var result = user.Result;

            Assert.AreEqual(-3, result);
        }
    }
}