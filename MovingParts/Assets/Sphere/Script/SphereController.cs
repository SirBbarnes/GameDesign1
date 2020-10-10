using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    public Rigidbody myRig;
    // Start is called before the first frame update
    void Start()
    {
        myRig = this.gameObject.GetComponent<Rigidbody>();

        if (myRig == null)
        {
            throw new System.Exception("NO RIGID BODY ON GAME OBJECT");
        }
        //myRig.velocity = new Vector3(5, 0, 0);
    }


    void OnCollisionEnter(Collision collision)
    { 
        foreach (ContactPoint contact in collision.contacts)
        {
            var rand = Random.Range(1, 5);
            //var rando = Random.Range(1,5);

             
            Debug.DrawRay(contact.point, contact.normal, Color.white);
            Debug.Log("Crash");
            Debug.Log("#: " + rand);

            switch (rand)
            {
                case 1:
                    //Debug.Log("Up");
                    myRig.velocity = new Vector3(1, 0, 10);
                   // Debug.Log("Z velocity" + myRig.velocity.z);
                    break;
                case 2:
                    //Debug.Log("Right");
                    myRig.velocity = new Vector3(10, 0, 1);
                    //Debug.Log("X velocity" + myRig.velocity.x);
                    break;
                case 3:
                    //Debug.Log("Down");
                    myRig.velocity = new Vector3(1, 0, -10);
                   //Debug.Log("Z velocity" + myRig.velocity.z);
                    break;
                case 4:
                   //Debug.Log("Left");
                    myRig.velocity = new Vector3(-10, 0, 1);
                   //Debug.Log("X velocity" + myRig.velocity.x);
                    break;
                default:
                    Debug.Log("Why is this the way it is?");
                    break;
            }
        }

    }

    /*
    void OnCollisionStay(Collision collisionInfo)
    {
        foreach (ContactPoint contact in collisionInfo.contacts)
        {
            var rand = Random.Range(1, 5);
            //var rando = Random.Range(1,5);


            Debug.DrawRay(contact.point, contact.normal, Color.white);
            Debug.Log("Crash");
            Debug.Log("#: " + rand);

            switch (rand)
            {
                case 1:
                    Debug.Log("Up");
                    myRig.velocity = new Vector3(0, 0, 10);
                    Debug.Log("Z velocity" + myRig.velocity.z);
                    break;
                case 2:
                    Debug.Log("Right");
                    myRig.velocity = new Vector3(10, 0, 0);
                    Debug.Log("X velocity" + myRig.velocity.x);
                    break;
                case 3:
                    Debug.Log("Down");
                    myRig.velocity = new Vector3(0, 0, -10);
                    Debug.Log("Z velocity" + myRig.velocity.z);
                    break;
                case 4:
                    Debug.Log("Left");
                    myRig.velocity = new Vector3(-10, 0, 0);
                    Debug.Log("X velocity" + myRig.velocity.x);
                    break;
                default:
                    Debug.Log("Why is this the way it is?");
                    break;
            }
        }
    }
    */

    // Update is called once per frame
    void Update()
    {
        if (myRig.velocity.x == 0f || myRig.velocity.z == 0)
        {
            var rand = Random.Range(1, 5);
            switch (rand)
            {
                case 1:
                    //Debug.Log("Up");
                    myRig.velocity = new Vector3(1, 0, 10);
                    // Debug.Log("Z velocity" + myRig.velocity.z);
                    break;
                case 2:
                    //Debug.Log("Right");
                    myRig.velocity = new Vector3(10, 0, 1);
                    //Debug.Log("X velocity" + myRig.velocity.x);
                    break;
                case 3:
                    //Debug.Log("Down");
                    myRig.velocity = new Vector3(1, 0, -10);
                    //Debug.Log("Z velocity" + myRig.velocity.z);
                    break;
                case 4:
                    //Debug.Log("Left");
                    myRig.velocity = new Vector3(-10, 0, 1);
                    //Debug.Log("X velocity" + myRig.velocity.x);
                    break;
                default:
                    Debug.Log("Why is this the way it is?");
                    break;
            }
        }
    }
}
