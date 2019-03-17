using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateDialog : MonoBehaviour
{

    public TextAsset ta;
    DialogXMLDeserialize dialog;
    public int CurrentNode;
    public bool ShowDialogue = true;

    public GUISkin skin;

    public List<Answer> answers = new List<Answer>();

    // Use this for initialization
    void Start()
    {
        PlayerPrefs.DeleteAll();
        dialog = DialogXMLDeserialize.Load(ta);
        UpdateAnswers();
    }

    private void UpdateAnswers()
    {
        answers.Clear();

        for (int i = 0; i < dialog.Nodes[CurrentNode].answers.Length; i += 1)
        {
            if(dialog.Nodes[CurrentNode].answers[i].QuestName == null || dialog.Nodes[CurrentNode].answers[i].NeedQuestValue == PlayerPrefs.GetInt(dialog.Nodes[CurrentNode].answers[i].QuestName))
            {
                answers.Add(dialog.Nodes[CurrentNode].answers[i]);
            }
            
        }

    }

    private void OnGUI()
    {
       
        GUI.skin = skin;
        if (ShowDialogue)
        {
            GUI.Box(new Rect(Screen.width / 2 - 300, Screen.height - 300, 600, 250), "");
            GUI.Label(new Rect(Screen.width / 2 - 250, Screen.height - 280, 500, 90), dialog.Nodes[CurrentNode].NpcText);

            for (int i = 0; i < answers.Count; i += 1)
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 250, Screen.height - 200 + 30 * i, 500, 25), answers[i].Text, skin.label))
                {
                    if (answers[i].QuestValue > 0)
                    {
                        PlayerPrefs.SetInt(answers[i].QuestName, answers[i].QuestValue);
                    }
                    if (answers[i].DialogueEnd)
                    {
                        ShowDialogue = false;
                    }
                    CurrentNode = answers[i].ToNode;

                    UpdateAnswers();
                }
            }
        }


    }
}
