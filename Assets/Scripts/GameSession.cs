using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSession: MonoBehaviour
{
    // config params
    [Range(0, 10)] [SerializeField] float gameSpeed;
    [SerializeField] int scorePerBlockDestoryed = 83;
    [SerializeField] TextMeshProUGUI scoreText;

    // state variables
    [SerializeField] int currentScore = 0;


    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameSession>().Length;
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        scoreText.text = currentScore.ToString();    
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void AddToScore()
    {
        currentScore += scorePerBlockDestoryed;
        scoreText.text = currentScore.ToString();
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }
}
