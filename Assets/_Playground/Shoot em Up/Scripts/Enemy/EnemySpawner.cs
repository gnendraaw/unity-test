using System.Collections.Generic;
using UnityEngine;

namespace Playground.Shmup
{
    public class EnemySpawner : MonoBehaviour {
        [SerializeField] private List<EnemyType> enemyTypes; // List of enemy types
        [SerializeField] private int maxEnemies = 10; // Number of max enemies spawned
        [SerializeField] private float spawnInterval = 2f; // Interval spawning between enemies
        [SerializeField] private float minX = -8f; // Minimum x axis value for spawning enemy
        [SerializeField] private float maxX = 8f; // Maximum x axis value for spawning enemy
        [SerializeField] private float valueY = 8f; // Y axis value for spawning enemy
        [SerializeField] private Transform parent; // Enemies spawned object parent

        private EnemyFactory factory; // Factory to create enemy instance
        private float spawnTimer; // Current timer to spawn enemy
        private int enemiesSpawned; // Counts of enemies spawned

        private void Awake() => factory = new EnemyFactory();

        private void Update() {
            spawnTimer += Time.deltaTime;

            if (enemiesSpawned < maxEnemies && spawnTimer >= spawnInterval) {
                spawnTimer = 0f; // Resets timer
                SpawnEnemy();
            }
        }

        private void SpawnEnemy() {
            EnemyType type = enemyTypes[Random.Range(0, enemyTypes.Count)];
            
            // TODO: Possible optimization - Pool enemies
            var instance = factory.CreateEnemy(type);

            // TODO: Update to better logic for setting enemy rotation & parent
            instance.transform.SetParent(parent);
            instance.transform.position = new Vector3(Random.Range(minX, maxX), valueY);
            instance.transform.rotation = parent.rotation;

            enemiesSpawned++;
        }
    }
}