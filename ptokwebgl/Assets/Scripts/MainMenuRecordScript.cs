using UnityEngine;
using UnityEngine.UI;

public class MainMenuRecordScript : MonoBehaviour
{
    public Text highScoreText;

    void Start()
    {
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "RECORD: " + highScore.ToString();
    }
}
