using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Learning.Dialogue {
    public class DialogueManager : MonoBehaviour {
        [Header("DIALOGUE BOX")]
        [SerializeField] private TextMeshProUGUI _messageText;
        [SerializeField] private TextMeshProUGUI _nameText;
        [SerializeField] private Image _icon;
        [SerializeField] private Animator _animator;

        private List<DialogueLine> _lines = new List<DialogueLine>();
        private List<DialogueActor> _actors = new List<DialogueActor>();
        private int _lineIndex;
        private bool isDialogueActive;

        public void StartDialogue(List<DialogueLine> lines, List<DialogueActor> actors) {
            _lines.Clear();

            _lines = lines;
            _actors = actors;
            _lineIndex = -1;
            isDialogueActive = true;
            _animator.SetBool("isActive", isDialogueActive);

            DisplayNextDialogue();
        }

        public void DisplayNextDialogue() {
            _lineIndex++;

            if (_lineIndex >= _lines.Count) {
                Debug.Log($"Converstaion Ended");
                isDialogueActive = false;
                _animator.SetBool("isActive", isDialogueActive);
                return;
            }

            var line = _lines[_lineIndex];
            _messageText.text = line.Line;
            _nameText.text = _actors[line.Id].Name;
            _icon.sprite = _actors[line.Id].Sprite;
        }

        private void Update() {
            HandleNextDialogueInput();
        }

        private void HandleNextDialogueInput() {
            if (Input.GetKeyDown(KeyCode.Space) && isDialogueActive) {
                DisplayNextDialogue();
            }
        }
    }
}