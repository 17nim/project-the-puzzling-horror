using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AnswersScript : MonoBehaviour
{
    public bool isCorrect;
    public QuizManager quizManager;

    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("Correct Answer");
            try
            {
                quizManager.correct();
            }
            catch (System.Exception)
            {
                SceneManager.LoadScene("Pass-Quiz");
            }
        }
        else
        {
            SceneManager.LoadScene("JumpScare");
        }
    }
}
