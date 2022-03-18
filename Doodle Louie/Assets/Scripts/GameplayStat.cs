using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayStat : MonoBehaviour
{
    public Text scoreText;
    public Text HighScore;
    public PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        HighScore.text = PlayerPrefs.GetInt("HS").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Your HS is:" + playerMovement.score.ToString();
    }
}
