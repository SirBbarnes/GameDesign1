using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public GameObject play, clone;
    public Rigidbody myRig;
    float randY, randZ;
    public static int score;
    int bumpForce = 100;
    public static int r1, r2, r3, r4;
    public static bool spawn;



     
    // Start is called before the first frame update
    void Start()
    {
        clone = play;
        myRig = clone.GetComponent<Rigidbody>();
        if (myRig == null)
            throw new System.Exception("NO RIGID BODY ON GAME OBJECT");


        randY = UnityEngine.Random.Range(8, 9);
        randZ = UnityEngine.Random.Range(-4, 3.5f);
        myRig.transform.position = new Vector3(0, randY, randZ);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            myRig.AddExplosionForce(bumpForce, myRig.transform.position, 1);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ring")
        {
            //Debug.Log("Ring");
            score += 50;
            //Debug.Log("Score: " + score);
            Destroy(clone);
            r1 += 1;
            //SpawnControl.spawn = false;
            //Debug.Log("Inner Ring: " + r1);
        }

        else if (other.gameObject.tag == "Ring2")
        {
            //Debug.Log("Ring2");
            score += 25;
            //Debug.Log("Score: " + score);
            Destroy(clone);
            r2 += 1;
            //SpawnControl.spawn = false;
            //Debug.Log("Middle Ring: " + r2);
        }

        else if (other.gameObject.tag == "Ring3")
        {
            //Debug.Log("Ring3");
            score += 10;
            //Debug.Log("Score: " + score);
            Destroy(clone);
            r3 += 1;
            //SpawnControl.spawn = false;
            //Debug.Log("Outer Ring: " + r3);
        }

        else if (other.gameObject.CompareTag("Coin"))
        {
           
            score += 1;
            other.gameObject.SetActive(false);

        }

        else if (other.gameObject.tag == "Ring1")
        {
            //Debug.Log("Ring1");
            Destroy(clone);
            spawn = true;
            r4 += 1;
            //Debug.Log("Multi-Ball Ring: " + r4);
        }
    }
    

    // Update is called once per frame
    void Update()
    {

    }
        
}   
