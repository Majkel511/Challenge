using ChellengeApp2;


namespace ChellengeApp2_Test
{
    public class TypeTest
    {
        [Test]
        public void checkingIfTheNumbersAreNotDifferent_int() 
        {
            int number3 = 5;
            int number4 = 2;

            Assert.AreNotEqual(number3, number4);

        }
        [Test]
        public void checkingIfTheNameAreNotDifferent()
        {
            string Name = "Michal";
            string Name_2 = "Magda";
           
            Assert.AreNotEqual(Name, Name_2);

        }
        [Test]
        public void checkingIfTheNumbersAreNotDifferent_var()
        {
            var number1 = 5;
            var number2 = 2;

            Assert.AreNotEqual(number1, number2);

        }
        [Test]
        public void ChceckingIfTheUserAreNotDifferent()
        {
            var user1 = GetUser("Adam");
            var user2 = GetUser("Zosia");

            Assert.AreNotEqual(user1, user2);

        }
        private Employee GetUser(string name)
        {
            return new Employee(name);
        }

    }
}
