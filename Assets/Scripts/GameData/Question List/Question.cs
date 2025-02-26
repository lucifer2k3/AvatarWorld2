using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question : MonoBehaviour
{

    public Quest quest;
    private static Question instance;
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
    public question_type type;
    public string Question;
    public string answer;
} 