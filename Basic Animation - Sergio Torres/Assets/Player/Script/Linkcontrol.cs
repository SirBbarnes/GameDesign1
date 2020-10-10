using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linkcontrol : MonoBehaviour
{
    public Animator myAnim;
    public Rigidbody2D myRig;
    float idleTimer = 3.0f;
    float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
        myRig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            //Up MovD
            myAnim.SetInteger("DIR", 0);
            myAnim.SetInteger("DIRIDLE", 4);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            //Up Idle
            myAnim.SetInteger("DIRIDLE", 0);
            myAnim.SetInteger("DIR", 4);

        }






        if (Input.GetKeyDown(KeyCode.D))
        {
            //Right Move
            myAnim.SetInteger("DIR", 1);
            myAnim.SetInteger("DIRIDLE", 4);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            //Right Idle
            myAnim.SetInteger("DIRIDLE", 1);
            myAnim.SetInteger("DIR", 4);

        }






        if (Input.GetKeyDown(KeyCode.S))
        {
            //Down Move
            myAnim.SetInteger("DIR", 2);
            myAnim.SetInteger("DIRIDLE", 4);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            //Down Idle
            myAnim.SetInteger("DIRIDLE", 2);
            myAnim.SetInteger("DIR", 4);

        }






        if (Input.GetKeyDown(KeyCode.A))
        {
            //Left Move
            myAnim.SetInteger("DIR", 3);
            myAnim.SetInteger("DIRIDLE", 4);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            //Left Idle
            myAnim.SetInteger("DIRIDLE", 3);
            myAnim.SetInteger("DIR", 4);

        }
    }
}
