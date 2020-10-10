using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggControl : MonoBehaviour
{
    public Animator myAnim;
    float rotateSpeed = 90.0f;
    float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }



    // Update is called once per frame
    void Update()
    {
        var moveAm = speed * Time.deltaTime;
        var rotateAm = rotateSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            myAnim.SetTrigger("Walk");
            Debug.Log("Up");
            transform.Translate(0, 0, moveAm);
        }

        if (Input.GetKey(KeyCode.S))
        {
            myAnim.SetTrigger("Walk");
            //Debug.Log("Down");
            transform.Translate(0, 0, -moveAm);
        }

        if (Input.GetKey(KeyCode.A))
        {
            myAnim.SetTrigger("Walk");
            //Debug.Log("Left");
            transform.Rotate(0, -rotateAm, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            myAnim.SetTrigger("Walk");
            //Debug.Log("Right");
            transform.Rotate(0, rotateAm, 0);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            myAnim.SetTrigger("Death");
            //myAnim.SetInteger("DIR", 0);
        }

        if (Input.GetMouseButton(0))
        {
            myAnim.SetTrigger("Hit");
        }

        
        //myAnim.SetInteger("DIR", 0);

    }
}
