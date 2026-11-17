namespace SkeletonTests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            int attack= 10; 
            int durability = 10;
            int health = 10;
            int experience = 15;
            int expectedResult = 9;

            Axe axe = new Axe(attack, durability);
            Dummy dummy = new Dummy(health, experience);

            axe.Attack(dummy);

            Assert.That(axe.DurabilityPoints, Is.EqualTo(expectedResult), "Axe Durability doesn't change after attack.");


        }

        [Test]
        public void BrokenAxeCantAttack()
        {
            Axe axe = new Axe(2, 2);
            Dummy dummy = new Dummy(20, 20);
            //Act
            axe.Attack(dummy);
            axe.Attack(dummy);

            //Assert
            var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.That(ex.Message, Is.EqualTo("Axe is broken."));
        }

        //Assert.IsTrue(bool condition, string message);
        //Assert.AreEqual(expected value, actual value);
        //Assert.Throws(Type expectedExceptionType, TestDelegate code);

        //StringAssert.Contains(string expected, string actual);
        //CollectionAssert.Contains(IEnumerable expected, object actual);
        //FileAssert.AreEqual(FileInfo expected, FileInfo actual);

        
    }
}
