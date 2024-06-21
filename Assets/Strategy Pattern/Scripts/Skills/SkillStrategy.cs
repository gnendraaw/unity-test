using UnityEngine;

namespace Strategy {
    public abstract class SkillStrategy : ScriptableObject {
        public abstract void CastSkill(Transform origin);
    }
}