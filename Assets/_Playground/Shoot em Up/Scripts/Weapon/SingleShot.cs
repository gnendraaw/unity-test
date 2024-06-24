using UnityEngine;

namespace Playground.Shmup
{
    [CreateAssetMenu(fileName = "Weapon Strategy", menuName = "Playground/Shmup/WeaponStrategy/SingleShot")]
    public class SingleShot : WeaponStrategy {
        public override void Fire(Transform firePoint, LayerMask layer) {
            var projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
            projectile.transform.SetParent(firePoint);
            // projectile.layer = layer;

            var projectileComponent = projectile.GetComponent<Projectile>();
            projectileComponent.SetSpeed(projectileSpeed);
            projectileComponent.SetDamage(Damage);

            Destroy(projectile, projectileLifetime);
        }
    }
}