using UnityEngine;
<<<<<<< HEAD
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;

    int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text = score.ToString() + "POINTS";
    }

    // Update is called once per frame
    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + "POINTS";

=======

public class ScoreManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
>>>>>>> 72f4554119d65a96a04a2347b6c8b01fa230e303
    }
}
