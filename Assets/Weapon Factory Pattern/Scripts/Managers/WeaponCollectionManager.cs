using System.Collections.Generic;
using UnityEngine;

namespace UnityTest.WeaponFactoryPattern {
    public class WeaponCollectionManager : MonoBehaviour {
        public static WeaponCollectionManager Instance { get; private set; }

        [SerializeField] private List<WeaponSO> weaponSOList = new List<WeaponSO>();

        private List<IWeaponChangeObserver> observers = new List<IWeaponChangeObserver>();

        public List<WeaponSO> WeaponSOList => weaponSOList;

        private void Awake() {
            // Initialize Singleton
            if (Instance == null) 
                Instance = this;
            else   
                Destroy(gameObject);
        }

        public void RegisterObserver(IWeaponChangeObserver observer) {
            if (!observers.Contains(observer)) {
                observers.Add(observer);
            }
        }

        public void UnregisterObserver(IWeaponChangeObserver observer) {
            if (observers.Contains(observer)) {
                observers.Remove(observer);
            }
        }

        public void SelectWeapon(WeaponSO so) {
            foreach (var observer in observers) {
                observer.OnWeaponChange(so);
            }
        }
    }
}