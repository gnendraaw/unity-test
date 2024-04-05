using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace UnityTest.LINQ {
    public class LocalDataSources : MonoBehaviour {
        [SerializeField] private DatabaseHelper _databaseHelper;

        public List<UnitModel> GetUnits() {
            var result = _databaseHelper.GetUnits;
            return result.Select(data => UnitModel.FromStats(data)).ToList();
        }

        public void AddUnit(UnitModel model) {
            _databaseHelper.AddUnit(model.ToStats());
        }
    }
}