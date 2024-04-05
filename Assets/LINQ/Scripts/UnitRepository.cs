using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace UnityTest.LINQ {
    public class UnityRepository : MonoBehaviour {
        [SerializeField] private List<Stats> _unitStats = new List<Stats>();

        public List<Unit> GetUnits() {
            List<Unit> units = _unitStats.Select(x => UnitModel.FromStats(x).ToEntity()).ToList();
            return units;
        }
    }
}