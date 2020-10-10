using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    float yVal = 0;
    public Rigidbody myRig;
    // Start is called before the first frame update
    void Start()
    {
        myRig = this.gameObject.GetComponent<Rigidbody>();
        if (myRig == null)
        {
            throw new System.Exception("NO RIGID BODY ON GAME OBJECT");
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        float temp;
        temp = myRig.transform.position.y;

        if (temp > yVal)
        {
            
            yVal = temp;
        }

        Debug.Log("This is the highest y: " + yVal);
    }
}
