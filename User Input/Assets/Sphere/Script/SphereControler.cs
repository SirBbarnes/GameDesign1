using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControler : MonoBehaviour
{
    public Rigidbody myRig;
    public bool canJump;
    Rect windowRect = new Rect(0, 0, 100, 100);
    bool win = false;

    // Start is called before the first frame update
    void Start()
    {
        myRig = GetComponent<Rigidbody>();
        if (myRig == null)
        {
            throw new System.Exception("NO RIGID BODY ON GAME OBJECT");
        }
        myRig.velocity = new Vector3(0, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Floor") && canJump == false)
            canJump = true;

        else if (collision.gameObject.tag == ("Finish") && canJump == false)
        {
            canJump = true;
            Debug.Log("Finished");
            win = true;
        }
    }

    private void OnGUI()
    {
        if (win == true)
        {
            windowRect = GUILayout.Window(0, windowRect, MyWindow, "Win!");

        }
    }

    void MyWindow(int windowID)
    {
        if (GUILayout.Button("You Win"))
        {
            print("You Win");
        }
    }

    // Update is called once per frame
    void Update()
    {
       //Debug.Log(Input.GetAxisRaw("Horizontal"));
        myRig.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * 2, myRig.velocity.y, 0);

        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            Debug.Log("Jump");
            myRig.velocity = Vector3.up * 4;
            canJump = false;
        }
    }
}
