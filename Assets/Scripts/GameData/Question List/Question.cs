using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question : MonoBehaviour
{

    public List<Quest> quest;
    public static Question instance;
    private void Awake()
    {
        instance= this;
    }
}
[System.Serializable]
public class Quest
{
    public enum question_type{
        math,
        history,
        chemistry
    }
    public int quest_id;
    public question_type type;
    public string Question;
    public string answer;
    public string answerA;
    public string answerB;
    public string answerC;
    public string answerD;
} 