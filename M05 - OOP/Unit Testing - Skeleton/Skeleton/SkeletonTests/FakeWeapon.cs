using Skeleton;
namespace SkeletonTests
{
    public class FakeWeapon : IWeapon
    {
       public int AttackPoints => 10;

        public int DurabilityPoints => 20;

        public void Attack(ITarget target)
        {
            
        }
    }
}
