namespace Playground.Shmup
{
    public class Enemy : Plane {
        protected override void Die() {
            // TODO: Destroy enemy object
            Destroy(gameObject);
            // TODO: Decrease enemy count in game manager
            // TODO: Increase game score by certain amount
        }
    }
}