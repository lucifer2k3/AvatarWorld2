using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class AnswerControl : MonoBehaviour
{
    private TextMeshProUGUI answerText;
    
    void Awake()
    {
        answerText = GetComponentInChildren<TextMeshProUGUI>(); 
    }
    public void OnClick()
    {
        QAControl.player_ans = answerText.text.ToString();
        QAControl.question_state = 1;
    }

}
