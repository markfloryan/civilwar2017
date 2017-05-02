using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.DialogueModel
{
    class Dialogue
    {
        private String[] _dialogues;
        private int _currDialogueIndex;
        private int _answerIndex;

        public Dialogue(String[] dialogues)
        {
            _dialogues = dialogues;
            _currDialogueIndex = 0;
            _answerIndex = -1;
        }

        public String GetCurrentDialogue()
        {
            if (_answerIndex >= 0 && _dialogues.Length > _currDialogueIndex)
            {
                string[] s = _dialogues[_currDialogueIndex].Split('|');
                if (_answerIndex < s.Length)
                {
                    return s[_answerIndex];
                }
                else
                {
                    return _dialogues[_currDialogueIndex];
                }
            }
            else
            {
                if (_currDialogueIndex < _dialogues.Length)
                {
                    return _dialogues[_currDialogueIndex];
                }
                else
                {
                    return "#END";
                }
            }
        }

        public String GetNextDialogue(int answerIndex)
        {
            _currDialogueIndex++;
            if(answerIndex >= 0)
            {
                _answerIndex = answerIndex;
            }

            if (_currDialogueIndex < _dialogues.Length)
            {
                if(_dialogues[_currDialogueIndex].Contains("%"))
                {
                    _answerIndex = -1;
                }

                return _dialogues[_currDialogueIndex];
            }
            else
            {
                return "#END";
            }
        }

        public void ResetDialogue()
        {
            _currDialogueIndex = 0;
            _answerIndex = -1;
        }
    }
}
