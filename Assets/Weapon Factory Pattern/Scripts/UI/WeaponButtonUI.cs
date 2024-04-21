using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityTest.WeaponFactoryPattern {
    public class WeaponButtonUI : MonoBehaviour, IPointerClickHandler {
        [SerializeField] private TextMeshProUGUI _weaponName;

        private WeaponSO weapon;

        public void Initialize(WeaponSO so) {
            weapon = so;
            _weaponName.text = so.Name;
        }

        public void OnPointerClick(PointerEventData eventData) {
            WeaponCollectionManager.Instance.SelectWeapon(weapon);
        }
    }
}