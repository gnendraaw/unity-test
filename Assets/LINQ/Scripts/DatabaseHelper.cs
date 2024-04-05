using System.Collections.Generic;
using UnityEngine;

namespace UnityTest.LINQ {
    public class DatabaseHelper : MonoBehaviour {
        [SerializeField] private List<Stats> _stats = new List<Stats>();

        public List<Stats> GetUnits => _stats;

        public void AddUnit(Stats stats) {
            _stats.Add(stats);
        }
    }
}