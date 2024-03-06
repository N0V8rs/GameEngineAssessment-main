using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [Header("Score")]
    public int score = 0;
    public  TMP_Text scoreText;

    [Header("Hide&Show")]
    public Image chestImage;
    public Button showButton;
    public Button hideButton;

    [Header("Color Silders")]
    public Image danielLarson;
    public Slider red;
    public Slider green;
    public Slider blue;
    public Slider alpha;

    [Header("Progress Bar")]
    public Slider progress;
    public TMP_Text percemtageText;

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
        score = Mathf.Clamp(score, 0, 999999999);

        scoreText.text = "Score: " + score.ToString("N0"); // Displays the text
    }

    public void ButtonRandom(int value)
    {
        score = Random.Range(-999999999, 999999999);
        score = Mathf.Clamp(score, 0, 999999999);
        scoreText.text = "Score: " + score.ToString("N0");
        Debug.Log(scoreText.text);
    }

    public void ColorChange()
    {
        Color color = danielLarson.color;

        float RedValue = red.value / red.maxValue;
        float GreenValue = green.value / green.maxValue;
        float BlueValue = blue.value / blue.maxValue;
        float AplhaValue = alpha.value / alpha.maxValue;

        color.r = RedValue;
        color.g = GreenValue;
        color.b = BlueValue;
        color.a = AplhaValue;

        danielLarson.color = color;
    }

    public void ProssgressBarFilling(float value)
    {
        progress.value += value;
        PercentageText();
    }

    public void PercentageText()
    {
        float percentage = (progress.value / progress.maxValue) * 100f;
        percemtageText.text = $"Progress: {percentage:F2}%";
    }

    public void hideKey()
    {
        hideButton.gameObject.SetActive(false);
        showButton.gameObject.SetActive(true);
        chestImage.gameObject.SetActive(false);
    }

    public void ShowKey()
    {
        hideButton.gameObject.SetActive(true);
        showButton.gameObject.SetActive(false);
        chestImage.gameObject.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}