using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControl : MonoBehaviour
{
    public GameObject play;
    public Vector3 pos;
    public static int ballSpawn = 3;
    public static bool playSpawn;
    public static bool spawn = false;
    // Start is called before the first frame update
    void Start()
    {
        
        pos = new Vector3(0, 7, 0);
    }

    // Update is called once per frame
    void Update()
    {
        playSpawn = BallControl.spawn;
        if (playSpawn == true)
        {
            BallControl.spawn = false;
            Instantiate(play, pos, Quaternion.identity);
            Instantiate(play, pos, Quaternion.identity);
            Instantiate(play, pos, Quaternion.identity);

        }
        else if (Input.GetKeyDown(KeyCode.Space) && ballSpawn != 0 /*&& spawn == false*/)
        {
            ballSpawn -= 1;
            Debug.Log("Space");
            Instantiate(play, pos, Quaternion.identity);
            //spawn = true;

        }

        else if (ballSpawn == 0)
        {
            Debug.Log("Outer Ring: " + BallControl.r3);
            Debug.Log("Middle Ring: " + BallControl.r2);
            Debug.Log("Inner Ring: " + BallControl.r1);
            Debug.Log("Multi-Ball Ring: " + BallControl.r4);
        }

        

    }
}
