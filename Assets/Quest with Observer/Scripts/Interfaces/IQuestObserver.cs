namespace UnityTest.QuestWithObserver {
    public interface IQuestObserver {
        void OnQuestChanged(Quest quest);
    }
}