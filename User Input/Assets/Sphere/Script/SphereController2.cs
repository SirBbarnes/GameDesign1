using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SphereController2 : MonoBehaviour
{
    public Transform SpawnPoint;
    public Rigidbody myRig;
    public float speed = 2.0f;
    bool respawn = false;
    Rect windowRect = new Rect(0, 0, 100, 100);
    bool win = false;

    // Start is called before the first frame update
    void Start()
    {
        myRig = GetComponent<Rigidbody>();
       
        if (myRig == null)
            throw new System.Exception("NO RIGID BODY ON GAME OBJECT");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Respawn"))
        {
            Debug.Log("Respawn");
            respawn = true;
        }

        else if (collision.gameObject.tag == "Finish")
        {
            Debug.Log("Finish");
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
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized;
        myRig.AddForce(movement * speed);
       // myRig.velocity += new Vector3(0, myRig.velocity.y, 0) + movement;
        if (respawn)
        {
            //transform.position = SpawnPoint.position;
            //Application.LoadLevel(Application.loadedLevel);
            //SceneManager.GetActiveScene();
            SceneManager.LoadScene("Phase 2", LoadSceneMode.Single);
        }

       // myRig.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * 2, myRig.velocity.y, 0);
       //x myRig.velocity = new Vector3(Input.GetAxisRaw("Vertical") * 2, myRig.velocity.y, 0);
    }
}
