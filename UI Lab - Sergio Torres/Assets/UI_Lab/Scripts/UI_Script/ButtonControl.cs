using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
    public void ButtonClick()
    {
        PlayerControl.score++;
        Destroy(this.gameObject);
    }

}
