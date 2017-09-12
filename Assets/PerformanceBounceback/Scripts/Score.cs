using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    
    public GameManager gameManager;
    public Text text;
    public int score;
    private int printedScore = 0;

    // Use this for initialization
    void Start () {
        score = gameManager.score;
    }
	
	// Update is called once per frame
	void Update () {
        ChangeScore();
        }

    public void ChangeScore()
    {
        score = gameManager.score;
        if(score > printedScore)
        {
            printedScore = score;
            text.text = "Score: " + printedScore.ToString();
        }
    }
}
