using System.Collections.Generic;
using UnityEngine;

namespace UnityTest.LINQ {
    public class GatherUnits : MonoBehaviour {
        [SerializeField] private UnityRepository _repo;

        private List<Unit> units;

        private void Start() {
            units = _repo.GetUnits();

            foreach (Unit unit in units) {
                Debug.Log($"Unit Name: {unit.Name}");
            }
        }

        private void Update() {
            if (Input.GetKeyDown(KeyCode.T)) {
                CreateRandomUnit();
            }
        }

        private void CreateRandomUnit() {
            Unit unit = new Unit(
                name: "New Unit",
                health: 100,
                damage: 999
            );

            _repo.AddUnit(unit);
        }
    }
}