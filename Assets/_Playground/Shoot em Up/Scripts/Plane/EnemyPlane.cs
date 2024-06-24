namespace Playground.Shmup
{
    public class Enemy : Plane {
        protected override void Die() {
            // TODO: Destroy enemy object
            Destroy(gameObject);
            // TODO: Decrease enemy count in game manager
            GameManager.Instance.HandleEnemyDead(score: 10, deadCount: 1); // Update this argument. Currently hardcoded
        }
    }
}