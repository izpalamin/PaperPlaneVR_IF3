using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;

    int score = 0;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text = score.ToString() + "POINTS";
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + "POINTS";
    }

}
