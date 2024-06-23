using UnityEngine;

namespace Playground.Shmup
{
    [CreateAssetMenu(fileName = "EnemyType", menuName = "Playground/Shmup/EnemyType")]
    public class EnemyType : ScriptableObject {
        public GameObject EnemyPrefab;
        public GameObject Weapon;
        public float MoveSpeed;
    }
}