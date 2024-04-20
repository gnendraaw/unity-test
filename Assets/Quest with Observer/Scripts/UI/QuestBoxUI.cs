using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityTest.QuestWithObserver {
    public class QuestBoxUI : MonoBehaviour, IPointerClickHandler {
        [Header("QUEST'S")]
        [SerializeField] private TextMeshProUGUI _nameText;

        public string NameText => _nameText.text;

        public void SetNameText(string name) {
            _nameText.text = name;
        }

        public void OnPointerClick(PointerEventData eventData) {
            QuestManager.Instance.CompleteQuest(NameText);
        }
    }
}