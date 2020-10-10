using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMoveScript : MonoBehaviour
{
    Rigidbody myRig;
    int speed = 10;
    int rotateSpeed = 90;
    Vector3 respawn, fin;
    NavMeshAgent myNav = null;
    GameObject player;
    int goal = 0;
    bool ret = false;

    float x, y, z;

    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
        player = GameObject.Find("Player");
        myRig = GetComponent<Rigidbody>();

        
        if (myRig == null)
            throw new System.Exception("No Rigid Body on Game Object");

        respawn = GameObject.FindGameObjectWithTag("Respawn").transform.position;
//        myNav.destination = finish;
//        myNav.Resume();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            this.transform.position = respawn;
            //Debug.Log("Go Back");

        }
    }


    [System.Obsolete]
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish")
        {
            fin = GameObject.Find("FinishLine").transform.position;
            myNav = this.gameObject.GetComponent<NavMeshAgent>();
            myNav.destination = fin;
            myNav.Resume();
        }
    }



    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        var moveAm = speed * Time.deltaTime;
        var rotateAm = rotateSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            //Debug.Log("Up");
            transform.Translate(0, 0, moveAm);
        }

        if (Input.GetKey(KeyCode.S))
        {
            //Debug.Log("Down");
            transform.Translate(0, 0, -moveAm);
        }

        if (Input.GetKey(KeyCode.A))
        {
            //Debug.Log("Left");
            transform.Rotate(0, -rotateAm, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            //Debug.Log("Right");
            transform.Rotate(0, rotateAm, 0);
        }


    }
}
