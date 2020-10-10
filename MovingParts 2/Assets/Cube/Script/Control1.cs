using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control1 : MonoBehaviour
{
    public Rigidbody myRig;
    // Start is called before the first frame update
    void Start()
    {
        myRig = this.gameObject.GetComponent<Rigidbody>();

        myRig.velocity = new Vector3(0, 10, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
