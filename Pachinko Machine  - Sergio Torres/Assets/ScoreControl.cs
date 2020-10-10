using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreControl : MonoBehaviour
{

    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + BallControl.score.ToString();

        if (SpawnControl.ballSpawn == 0)
        {
            score.text = "You Win";
        }

        
    }
}
