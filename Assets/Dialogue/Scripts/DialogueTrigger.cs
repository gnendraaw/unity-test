using System.Collections.Generic;
using UnityEngine;

namespace Learning.Dialogue {
    public class DialogueTrigger : MonoBehaviour {
        [Header("LOGICS")]
        [SerializeField] private List<DialogueActor> _actors = new List<DialogueActor>();
        [SerializeField] private List<DialogueLine> _lines = new List<DialogueLine>();
        [SerializeField] private DialogueManager _manager;

        public List<DialogueActor> Actors => _actors;
        public List<DialogueLine> Lines => _lines;

        public void StartDialogue() {
            _manager.StartDialogue(actors: _actors, lines: _lines);
        }
    }

    [System.Serializable]
    public struct DialogueActor {
        public Sprite Sprite;
        public string Name;
    }

    [System.Serializable]
    public struct DialogueLine {
        public int Id;
        public string Line;
    }
}