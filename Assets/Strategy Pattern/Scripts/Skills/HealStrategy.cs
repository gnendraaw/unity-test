using UnityEngine;

namespace Strategy {
    [CreateAssetMenu(fileName = "Heal Strategy", menuName = "Strategy / Heal")]
    public class HealStrategy : SkillStrategy {
        public GameObject Prefab;
        public float Duration;
        public int AddAmountHealth;

        public override void CastSkill(Transform origin) {
            if (origin.TryGetComponent(out Hero hero)) {
                hero.AddHealth(AddAmountHealth);
            }
            Vector3 spawnPosition = origin.position;
            GameObject heal = Instantiate(Prefab, spawnPosition, origin.rotation);
            Destroy(heal, Duration);
        }
    }
}