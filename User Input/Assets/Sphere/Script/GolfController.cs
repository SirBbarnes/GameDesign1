using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfController : MonoBehaviour
{
    float x1, z1;
    float x2, z2;
    //public float speed = 50.0f;
    public float velX, VelZ;
    public Rigidbody myRig;
    bool canHit = true;
    public float speed = 5.0f;
    bool win = false;
    Rect windowRect = new Rect(0, 0, 100, 100);
    
    // Start is called before the first frame update
    void Start()
    {
        myRig = GetComponent<Rigidbody>();
        if (myRig == null)
            throw new System.Exception("NO RIGID BODY ON GAME OBJECT");

    }

    

    private void OnMouseDown()
    {
        RaycastHit myCheck;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out myCheck))
        {
            //Debug.Log("Z: " + myCheck.point.z);
            x1 = myCheck.point.x;
            z1 = myCheck.point.z;
        }
    }

    private void OnMouseDrag()
    {
        RaycastHit myCheck;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out myCheck))
        {
            //Debug.Log("Z: " + myCheck.point.z);
            x2 = myCheck.point.x;
            z2 = myCheck.point.z;
        }
    }

    private void OnMouseUp()
    {
        velX = myRig.velocity.x;
        VelZ = myRig.velocity.z;
        if (velX == 0 && VelZ == 0)
        {
            float x3 = (x1 - x2) * 2;
            float z3 = (z1 - z2) * 2;
            //Debug.Log("Value: " + third);
            if (canHit == true)
            {
                myRig.velocity = new Vector3(x3, 0, z3);
                //Vector3 movement = new Vector3(x3, 0, z3);
                //myRig.AddForce(movement * speed);
            }
        }

    }

    public void OnGUI()
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

    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Debug.Log("Game Finished");
            win = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (myRig.velocity.x != 0 && myRig.velocity.z != 0)
        {
            Cursor.visible = false;
        }
        else
            Cursor.visible = true;
    }
}
