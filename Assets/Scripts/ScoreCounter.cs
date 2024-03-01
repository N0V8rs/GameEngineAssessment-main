using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    private int score = 0;
    public  TMP_Text scoreText;

    public void Awake()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void ButtonUP(int value) // Value == in Unity to asigned the value in the inspector
    {
        if (value == 0) // value = 0
        {
            score = 0;
        }

        score += value; // Adds the score

        scoreText.text = "Score: " + score.ToString(); // Displays the text
    }
}