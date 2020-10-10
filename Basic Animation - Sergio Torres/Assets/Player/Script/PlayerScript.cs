using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Animator myAnim;
    // Start is called before the first frame update
    void Start()
    {
        myAnim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            //left
            myAnim.SetInteger("DIR", 2);
        }

        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            //right
            myAnim.SetInteger("DIR", 1);
        }

        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            //down
            myAnim.SetInteger("DIR", 3);
        }

        else if (Input.GetAxisRaw("Vertical") > 0)
        {
            //up
            myAnim.SetInteger("DIR", 0);
        }
    }
}
