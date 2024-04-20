namespace UnityTest.QuestWithObserver {
    [System.Serializable]
    public class Quest {
        public string QuestName;
        public bool IsCompleted;

        public Quest(string questName) {
            QuestName = questName;
            IsCompleted = false;
        }

        public void Complete() {
            IsCompleted = true;
        }
    }
}