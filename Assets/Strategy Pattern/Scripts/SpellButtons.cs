using UnityEngine;
using UnityEngine.UI;

namespace Strategy {
    public class SpellButton : MonoBehaviour {
        [Header("BUTTONS")]
        [SerializeField] private Button fireBallButton;
        [SerializeField] private Button healButton;

        public delegate void OnButtonClick(Spell spell);
        public static event OnButtonClick onButtonClick;

        private void Awake() {
            fireBallButton.onClick.AddListener(() => {
                onButtonClick?.Invoke(Spell.Fireball);
            });

            healButton.onClick.AddListener(() => {
                onButtonClick?.Invoke(Spell.Buff);
            });
        }
    }
}