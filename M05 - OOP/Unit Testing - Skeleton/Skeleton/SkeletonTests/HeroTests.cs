using Moq;
using Skeleton;

namespace SkeletonTests
{
     [TestFixture]
    public class HeroTests
    {
        [Test]
        public void HeroTakesExperience()
        {
            IWeapon weapon = new FakeWeapon();
            ITarget target = new FakeTarget();
            string name = "Mitko";
            Hero hero = new Hero(name, weapon);
            int expectedResult = 20;

            hero.Attack(target);

            Assert.That(hero.Experience, Is.EqualTo(expectedResult));
        }

        [Test]
        public void HeroTakesExperienceUsingMock()
        {

            var weapon = new Mock<IWeapon>();
            var target = new Mock<ITarget>();
            target.Setup(t => t.IsDead()).Returns(true);
            target.Setup(t => t.GiveExperience()).Returns(20);

            string name = "Mitko";
            Hero hero = new Hero(name, weapon.Object);
            int expectedResult = 20;

            hero.Attack(target.Object);

            Assert.That(hero.Experience, Is.EqualTo(expectedResult));
        }
    }
}
