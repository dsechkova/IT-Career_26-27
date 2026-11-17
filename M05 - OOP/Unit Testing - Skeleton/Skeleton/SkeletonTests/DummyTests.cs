namespace SkeletonTests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void DummyLosesHealthIfAttacked()
        {
            Dummy dummy = new Dummy(10, 10);
            dummy.TakeAttack(3);
            Assert.That(dummy.Health, Is.EqualTo(7));
        }

        [Test]
        public void DeadDummyThrowsExceptionIfAttacked()
        {
            Dummy dummy = new Dummy(0, 10);
            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(5));
        }

        [Test]
        public void DeadDummyCanGiveXP()
        {
            Dummy dummy = new Dummy(0, 10);
            int xp = dummy.GiveExperience();
            Assert.That(xp, Is.EqualTo(10));
        }

        [Test]
        public void AliveDummyCantGiveXP()
        {
            Dummy dummy = new Dummy(10, 10);
            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        }


    }
}
