using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour {

    // массив узлов диалогов
    //public DialogueNode[] node;

    //public int CurrentNode;

    //public bool ShowDialogue = true;

	
    //private void OnGUI()
    //{

    //    if (ShowDialogue)
    //    {
    //        GUI.Box(new Rect(Screen.width / 2 - 300, Screen.height - 300, 600, 250), "");
    //        GUI.Label(new Rect(Screen.width / 2 - 250, Screen.height - 280, 500, 90), node[CurrentNode].NpcText);
    //        for (int i = 0; i < node[CurrentNode].PlayerAnswer.Length; i++)
    //        {
    //            if (GUI.Button(new Rect(Screen.width / 2 - 250, Screen.height - 200 + 25 * i, 500, 25), node[CurrentNode].PlayerAnswer[i].Text))
    //            {
    //                CurrentNode = node[CurrentNode].PlayerAnswer[i].ToNode;
    //                if (node[CurrentNode].PlayerAnswer[i].SpeekEnd)
    //                {
    //                    ShowDialogue = false;
    //                }
    //            }
    //        }
    //    }
        
    //}

}

//[System.Serializable]
//public class DialogueNode {
//    // текст НПС
//    public string NpcText;
//    // Массив ответов
//    public Answer[] PlayerAnswer;

//}

//[System.Serializable]
//public class Answer
//{
//    public string Text;
//    public int ToNode;
//    public bool SpeekEnd;
//}