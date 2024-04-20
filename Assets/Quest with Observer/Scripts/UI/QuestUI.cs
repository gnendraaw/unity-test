using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UnityTest.QuestWithObserver {
    public class QuestUI : MonoBehaviour, IQuestObserver {
        [Header("QUEST CREATION")]
        [SerializeField] private TMP_InputField _questNameField;
        [SerializeField] private Button _saveQuestButton;

        [Header("QUEST VISUALS")]
        [SerializeField] private Transform _questsContainer;
        [SerializeField] private QuestBoxUI _questBoxPrefab;

        private List<QuestBoxUI> questBoxes = new List<QuestBoxUI>();

        private void Awake() {
            _saveQuestButton.onClick.AddListener(() => {
                QuestManager.Instance.AddQuest(new Quest(_questNameField.text));
            });
        }

        private void Start() {
            QuestManager.Instance.RegisterObserver(this);
        }

        private void OnDestroy() {
            QuestManager.Instance.UnregisterObserver(this);
        }

        public void OnQuestChanged(Quest quest) {
            if (quest.IsCompleted) {
                // If quest is completed, remove its visual from the scene
                var result = questBoxes.FirstOrDefault(questBox => questBox.NameText == quest.QuestName);
                // Remove quest box from list
                questBoxes.Remove(result);
                // Destroy quest box gameObject
                Destroy(result.gameObject);
            } else {
                // Spawns new quest box visual
                var questBox = Instantiate(_questBoxPrefab, _questsContainer);
                // Set its name
                questBox.SetNameText(quest.QuestName);
                // Add spawned quest box to list
                questBoxes.Add(questBox);
            }
        }
    }
}