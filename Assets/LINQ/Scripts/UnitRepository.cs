using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace UnityTest.LINQ {
    public class UnityRepository : MonoBehaviour {
        [SerializeField] private LocalDataSources _localDataSources;

        public List<Unit> GetUnits() {
            var result = _localDataSources.GetUnits();
            return result.Select(model => model.ToEntity()).ToList();
        }

        public void AddUnit(Unit unit) {
            _localDataSources.AddUnit(unit.ToModel());
        }
    }
}