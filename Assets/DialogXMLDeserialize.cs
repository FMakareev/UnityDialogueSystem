using System.Collections;
using System.Xml.Serialization;
using System.IO;
using UnityEngine;

// Название корневого элемента в xml документе
[XmlRoot("dialogue")]
public class DialogXMLDeserialize
{

    // Название тэга в xml документе
    [XmlElement("node")]
    public Node[] Nodes;

    public static DialogXMLDeserialize Load(TextAsset _xml)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(DialogXMLDeserialize));
        StringReader reader = new StringReader(_xml.text);
        DialogXMLDeserialize dial = serializer.Deserialize(reader) as DialogXMLDeserialize;
        return dial;
    }
}

[System.Serializable]
public class Node
{
    [XmlElement("npctext")]
    public string NpcText;

    [XmlArray("answers")]
    [XmlArrayItem("answer")]
    public Answer[] answers;
}

[System.Serializable]
public class Answer
{
    [XmlElement("text")]
    public string Text;

    [XmlElement("dialogueend")]
    public bool DialogueEnd;

    [XmlElement("questname")]
    public string QuestName;

    [XmlAttribute("tonode")]
    public int ToNode;

    [XmlAttribute("questvalue")]
    public int QuestValue;

    [XmlAttribute("needquestvalue")]
    public int NeedQuestValue;
}