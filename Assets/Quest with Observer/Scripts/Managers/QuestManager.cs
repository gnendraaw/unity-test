using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace UnityTest.QuestWithObserver {
    public class QuestManager : MonoBehaviour {
        public static QuestManager Instance { get; private set; }

        private List<Quest> quests = new List<Quest>();
        private List<IQuestObserver> observers = new List<IQuestObserver>();

        private void Awake() {
            if (Instance == null) {
                Instance = this;
            } else {
                Destroy(gameObject);
            }
        }

        public void AddQuest(Quest quest) {
            quests.Add(quest);
            NotifyObservers(quest);
        }

        public void CompleteQuest(Quest quest) {
            quest.Complete();
            NotifyObservers(quest);
        }

        public void CompleteQuest(string questName) {
            var result = quests.FirstOrDefault(quest => quest.QuestName == questName && !quest.IsCompleted);
            if (result != null)
                CompleteQuest(result);
        }

        public void RegisterObserver(IQuestObserver observer) {
            if (!observers.Contains(observer))
                observers.Add(observer);
        }

        public void UnregisterObserver(IQuestObserver observer) { 
            if (observers.Contains(observer))
                observers.Remove(observer);
        }

        public void NotifyObservers(Quest quest) {
            foreach (var observer in observers) {
                observer.OnQuestChanged(quest);
            }
        }
    }
}