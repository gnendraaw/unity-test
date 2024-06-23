using UnityEngine;

namespace Playground.Shmup
{
    public class EnemyFactory {
        public GameObject CreateEnemy(EnemyType enemyType) {
            EnemyBuilder builder = new EnemyBuilder()
                .SetPrefab(enemyType.EnemyPrefab)
                .SetMoveSpeed(enemyType.MoveSpeed);

            return builder.Build();
        }

        // More factory methods, for spawning different enemies
    }
}