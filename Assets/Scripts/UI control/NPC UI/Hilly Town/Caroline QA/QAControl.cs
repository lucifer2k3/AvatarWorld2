using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;
public class QAControl : MonoBehaviour
{
    [SerializeField] private GameObject QA_Main;
    [SerializeField] private GameObject QA_enter_panel;
    // QA main UI
    [SerializeField]private TextMeshProUGUI questionTMP;
    [SerializeField]private TextMeshProUGUI answerATMP;
    [SerializeField]private TextMeshProUGUI answerBTMP;
    [SerializeField]private TextMeshProUGUI answerCTMP;
    //question
    private string question;
    private string[] ans_List= new string[3];
    public static string ans_True;
    private float discount=0;
    //check dung sai
    public static int question_state = 0;
    public static string player_ans ="";

    // tro chuyen
    [SerializeField] private string Caroline_conversation;
    [SerializeField] private Sprite npc_Image;

    //loi thoai khi tro truyen
    [SerializeField]private List<string> caroline_talk;
    [SerializeField]private List<Sprite> caroline_sprite;
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        switch (question_state)
        {
            case 1:
                if (player_ans == ans_True)
                {
                    //neu cau tra loi dung
                    Question.instance.discount = discount;
                    discount = 0;
                }
                else
                {
                    print(false);
                }
                question_state= 0;
                break;
        }
    }
    public void OpenTalk()
    {
        QA_enter_panel.SetActive(false);
        Convesation.Instance.OpenTalk();
        Convesation.Instance.AddTalk(caroline_talk, caroline_sprite);
    }
    public void GetQuestion()
    {

        int questionIndex = Question.instance.quest[Random.Range(0,Question.instance.quest.Count)].quest_id;
        //print(questionIndex);
        question = Question.instance.quest[questionIndex].Question;
        ans_List[0] = Question.instance.quest[questionIndex].answerA;
        ans_List[1] = Question.instance.quest[questionIndex].answerB;
        ans_List[2] = Question.instance.quest[questionIndex].answerC;
        
        ans_True = Question.instance.quest[questionIndex].answer;
        discount = Question.instance.quest[questionIndex].discount;


        questionTMP.text= question;
        answerATMP.text= ans_List[0];
        answerBTMP.text= ans_List[1];
        answerCTMP.text= ans_List[2];
    }
    public void OpenQAMain()
    {
        QA_Main.SetActive(true);
        QA_enter_panel.SetActive(false);
        GetQuestion();
    }
    public void Close_QA_Enter_Panel()
    {
        QA_enter_panel.SetActive(false);
    }
    public void Close_QA_()
    {
        QA_Main.SetActive(false);
    }
}
