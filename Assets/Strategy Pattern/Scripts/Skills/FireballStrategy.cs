
using UnityEngine;

namespace Strategy {
    [CreateAssetMenu(fileName = "Fireball Strategy", menuName = "Strategy / Fireball")]
    public class FireballStrategy : SkillStrategy {
        public GameObject Prefab;
        public float Duration;

        public override void CastSkill(Transform origin) {
            Vector3 spawnPosition = origin.position + Vector3.up;
            GameObject fireball = Instantiate(Prefab, spawnPosition, origin.rotation);
            Destroy(fireball, Duration);
        }
    }
}
