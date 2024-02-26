using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;
using TMPro.EditorUtilities;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public int score = 0;
    public TMP_Text Score;

    public void Awake()
    {
        
        Score.text = score.ToString();
    }
    public void ButtonUP(int value)
    {
        if (value == 0)
        {
            score = 0;
        }
        
        score += value;

        Score.text = score.ToString();
    }
}
