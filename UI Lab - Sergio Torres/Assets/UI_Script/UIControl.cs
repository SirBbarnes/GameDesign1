using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonHit()
    {
        Debug.Log("The button has been pressed.");
    }

    public void CheckBox(bool isCheck)
    {
        Debug.Log("The check box has been modified and its value is: " + isCheck);
    }

    public void SliderChange(float num)
    {
        Debug.Log("The slider value has changed and it is now: " + num);
    }

    public void StringEdit(string e)
    {
        Debug.Log("The current String is: " + e);
    }

    public void StringFinish(string e)
    {
        Debug.Log("The Finished String is: " + e);
    }

    public void DropChange(int choice)
    {
        Debug.Log("The index of the choice is: " + choice);
    }
}
