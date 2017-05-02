using Assets.DialogueModel;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayerBehavior : MonoBehaviour {
    public Canvas DialogueCanvas;
    public Text DialogueText;
    public Transform[] Reporters;
    public Transform[] Graves;
    public Transform[] Soldiers;
    public Transform[] Abolitionists;
    public Transform[] Newspapers;
    public Transform Douglass;
    public Transform Meade;
    public Transform Lincoln;

    private DialogueDatabase _dialogueDB;
    private bool _inDialogue;
    private bool _dialogueWait;
    private Dialogue _currDialogue;
    private int _availableAnswers;
    private bool _wait;
    private bool[] _reporterQuestsCompleted;
    private bool[] _newspaperQuestsCompleted;
    private bool _meadeQuestCompleted;
    private bool _douglassQuestCompleted;
    private bool _gameWon;
    
	private void Start () {
        DialogueCanvas.enabled = false;
        _dialogueDB = new DialogueDatabase();
        _inDialogue = false;
        _reporterQuestsCompleted = new bool[5] { false, false, false, false, false };
        _newspaperQuestsCompleted = new bool[3] { false, false, false };
        _meadeQuestCompleted = false;
        _douglassQuestCompleted = false;
        _gameWon = false;
	}
	
	private void Update () {
        if (!_gameWon)
        {
            if (!_wait)
            {
                if (_inDialogue)
                {
                    if (!_dialogueWait)
                    {
                        _availableAnswers = 0;
                        //process the next line here
                        string dialogue = _currDialogue.GetCurrentDialogue();
                        Debug.Log(dialogue);


                        if (dialogue.Contains("#startShipGame"))
                        {
                            bool finished = true;
                            for (int x = 0; x < _reporterQuestsCompleted.Length; x++)
                            {
                                if (!_reporterQuestsCompleted[x])
                                {
                                    finished = false;
                                    break;
                                }
                            }

                            for (int x = 0; x < _newspaperQuestsCompleted.Length; x++)
                            {
                                if (!_newspaperQuestsCompleted[x])
                                {
                                    finished = false;
                                    break;
                                }
                            }

                            if (finished && _meadeQuestCompleted && _douglassQuestCompleted)
                            {
                                _gameWon = true;
                                dialogue = "You did it! Here is the Emancipation Proclamation!";
                            }
                            else
                            {
                                dialogue = "Let me check if you have...";
                            }
                        }
                        else if (dialogue.Contains("#"))
                        {
                            if (dialogue.Contains("#END"))
                            {
                                _currDialogue.ResetDialogue();
                                _currDialogue = null;
                            }
                            else if (dialogue.Contains("#naval"))
                            {
                                _currDialogue.ResetDialogue();
                                _currDialogue = null;
                                _reporterQuestsCompleted[int.Parse(dialogue.Substring(dialogue.IndexOf("#naval") + 6, 1)) - 1] = true;
                            }
                            else if (dialogue.Contains("#paper"))
                            {
                                _currDialogue.ResetDialogue();
                                _currDialogue = null;
                                _newspaperQuestsCompleted[int.Parse(dialogue.Substring(dialogue.IndexOf("#paper") + 6, 1)) - 1] = true;
                            }
                            else if (dialogue.Contains("#gossip"))
                            {
                                _currDialogue.ResetDialogue();
                                _currDialogue = null;
                                _douglassQuestCompleted = true;
                            }
                            else if (dialogue.Contains("#customer"))
                            {
                                _currDialogue.ResetDialogue();
                                _currDialogue = null;
                                _meadeQuestCompleted = true;
                            }


                            _inDialogue = false;
                            DialogueCanvas.enabled = false;
                            return;
                        }

                        if (dialogue.Contains("%"))
                        {
                            DialogueText.text = dialogue.Substring(0, dialogue.IndexOf('%'));
                            dialogue = dialogue.Substring(dialogue.IndexOf('%') + 1);
                            string[] answers = dialogue.Split('|');
                            _availableAnswers = answers.Length;
                            for (int x = 0; x < answers.Length; x++)
                            {
                                switch (x)
                                {
                                    case 0:
                                        DialogueText.text += "\n\nup) " + answers[0];
                                        break;
                                    case 1:
                                        DialogueText.text += "\ndown) " + answers[1];
                                        break;
                                    case 2:
                                        DialogueText.text += "\nleft) " + answers[2];
                                        break;
                                    case 3:
                                        DialogueText.text += "\nright) " + answers[3];
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                        else
                        {
                            DialogueText.text = dialogue;
                            _availableAnswers = 0;
                        }

                        _dialogueWait = true;
                        StartCoroutine(InputWaitCoroutine());
                    }
                    else
                    {
                        int responseIndex = -1;
                        //wait for player input here
                        if (Input.GetAxis("Horizontal") > 0) //3
                        {
                            responseIndex = 3;
                        }
                        else if (Input.GetAxis("Horizontal") < 0) //2
                        {
                            responseIndex = 2;
                        }
                        else if (Input.GetAxis("Vertical") > 0) //0 
                        {
                            responseIndex = 0;
                        }
                        else if (Input.GetAxis("Vertical") < 0) //1 
                        {
                            responseIndex = 1;
                        }

                        if (responseIndex >= 0)
                        {
                            if (_availableAnswers > responseIndex)
                            {
                                _currDialogue.GetNextDialogue(responseIndex);
                            }
                            else if (_availableAnswers == 0)
                            {
                                _currDialogue.GetNextDialogue(-1);
                            }

                            _dialogueWait = false;
                        }
                    }
                }
                else
                {
                    if (Input.GetButtonDown("Fire1"))
                    {
                        DialogueCanvas.enabled = !DialogueCanvas.enabled;
                        string questProgress = "";
                        int rQC = 0;
                        int nQC = 0;
                        for (int x = 0; x < _reporterQuestsCompleted.Length; x++)
                        {
                            if (_reporterQuestsCompleted[x])
                            {
                                rQC++;
                            }
                        }

                        for (int x = 0; x < _newspaperQuestsCompleted.Length; x++)
                        {
                            if (_newspaperQuestsCompleted[x])
                            {
                                nQC++;
                            }
                        }

                        questProgress += rQC + "/5 reporters talked to\n";

                        questProgress += nQC + "/3 newspapers found\n";

                        if(_meadeQuestCompleted)
                        {
                            questProgress += "General Meade story heard\n";
                        }
                        else
                        {
                            questProgress += "General Meade story not heard\n";
                        }

                        if (_douglassQuestCompleted)
                        {
                            questProgress += "Got Frederick Douglass Notes\n";
                        }
                        else
                        {
                            questProgress += "Need Frederick Douglass Notes\n";
                        }


                        DialogueText.text = questProgress; 
                    }

                    if (Input.GetButtonDown("Fire2"))
                    {
                        HandleDialogue();
                    }
                }
            }
        }
    }

    private void HandleDialogue()
    {
        Vector3 position = transform.position;
        for (int x = 0; x < Reporters.Length; x++)
        {
            if(Vector3.Distance(position, Reporters[x].position) < 3)
            {
                if(!_reporterQuestsCompleted[x])
                {
                    DialogueCanvas.enabled = true;
                    _inDialogue = true;
                    _dialogueWait = false;
                    _currDialogue = _dialogueDB.GetReporterDialogue(x);
                }
                else
                {
                    DialogueCanvas.enabled = true;
                    _inDialogue = true;
                    _dialogueWait = false;
                    _currDialogue = new Dialogue(new string[1] { "You've already answered my questions!" });
                }
            }
        }

        for (int x = 0; x < Graves.Length; x++)
        {
            if (Vector3.Distance(position, Graves[x].position) < 3)
            {
                DialogueCanvas.enabled = true;
                _inDialogue = true;
                _dialogueWait = false;
                _currDialogue = _dialogueDB.GetGraveDialogue(x);
            }
        }

        for (int x = 0; x < Soldiers.Length; x++)
        {
            if (Vector3.Distance(position, Soldiers[x].position) < 3)
            {
                DialogueCanvas.enabled = true;
                _inDialogue = true;
                _dialogueWait = false;
                _currDialogue = _dialogueDB.GetSoldierDialogue(x);
            }
        }

        for (int x = 0; x < Abolitionists.Length; x++)
        {
            if (Vector3.Distance(position, Abolitionists[x].position) < 3)
            {
                DialogueCanvas.enabled = true;
                _inDialogue = true;
                _dialogueWait = false;
                _currDialogue = _dialogueDB.GetAbolitionistDialogue(x);
            }
        }

        for (int x = 0; x < Newspapers.Length; x++)
        {
            if (Vector3.Distance(position, Newspapers[x].position) < 4)
            {
                if (!_newspaperQuestsCompleted[x])
                {
                    DialogueCanvas.enabled = true;
                    _inDialogue = true;
                    _dialogueWait = false;
                    _currDialogue = _dialogueDB.GetNewspaperDialogue(x);
                }
                else
                {
                    DialogueCanvas.enabled = true;
                    _inDialogue = true;
                    _dialogueWait = false;
                    _currDialogue = new Dialogue(new string[1] { "You've already read my newspaper!" });
                }

            }
        }

        if (Vector3.Distance(position, Meade.position) < 3)
        {
            if (!_meadeQuestCompleted)
            {
                DialogueCanvas.enabled = true;
                _inDialogue = true;
                _dialogueWait = false;
                _currDialogue = _dialogueDB.GetMeadeDialogue();
            }
            else
            {
                DialogueCanvas.enabled = true;
                _inDialogue = true;
                _dialogueWait = false;
                _currDialogue = new Dialogue(new string[1] { "You've already heard my story!" });
            }
        }

        if (Vector3.Distance(position, Douglass.position) < 3)
        {
            if (!_douglassQuestCompleted)
            {
                DialogueCanvas.enabled = true;
                _inDialogue = true;
                _dialogueWait = false;
                _currDialogue = _dialogueDB.GetDouglassDialogue();
            }
            else
            {
                DialogueCanvas.enabled = true;
                _inDialogue = true;
                _dialogueWait = false;
                _currDialogue = new Dialogue(new string[1] { "You've already gotten my notes!" });
            }
        }

        if (Vector3.Distance(position, Lincoln.position) < 3)
        {
            DialogueCanvas.enabled = true;
            _inDialogue = true;
            _dialogueWait = false;
            _currDialogue = _dialogueDB.GetLincolnDialogue();
        }
    }

    private IEnumerator InputWaitCoroutine()
    {
        _wait = true;

        yield return new WaitForSeconds(.2f);

        _wait = false;
    }
}
