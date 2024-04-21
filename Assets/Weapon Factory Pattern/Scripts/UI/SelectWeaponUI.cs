using UnityEngine;

namespace UnityTest.WeaponFactoryPattern {
    public class SelectWeaponUI : MonoBehaviour {
        [SerializeField] private WeaponButtonUI _weaponButtonUI;
        [SerializeField] private Transform _buttonsContainer;

        private void Start() {
            foreach (var weapon in WeaponCollectionManager.Instance.WeaponSOList) {
                WeaponButtonUI button = Instantiate(_weaponButtonUI, _buttonsContainer);
                button.Initialize(weapon);
            }
        }
    }
}