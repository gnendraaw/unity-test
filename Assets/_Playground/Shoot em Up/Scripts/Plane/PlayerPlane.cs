using UnityEngine;

namespace Playground.Shmup
{
    public class PlayerPlane : Plane {
        protected override void Die() {
            // TODO: Add game over related logic
            Debug.Log("Game Over!");
        }
    }
}