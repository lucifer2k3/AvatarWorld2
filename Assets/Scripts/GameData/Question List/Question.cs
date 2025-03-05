using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question : MonoBehaviour
{

    public List<Quest> quest;
    public float discount = 1;
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


    //thong tin co ban
    public int quest_id;
    public question_type type;

    //ma giam gia
    public float discount = 1;

    public string Question;//cau hoi
    public string answer;//cau tra loi
    public string answerA;//dap an
    public string answerB;
    public string answerC;
    public string answerD;
} 