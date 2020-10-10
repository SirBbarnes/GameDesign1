using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int hp = 5;
    public int mhp = 10;

    public GameObject hpBar;
    public RectTransform hpTran;
    //private float maxWidth;
    // Start is called before the first frame update
    void Start()
    {
        hpTran = hpBar.GetComponent<RectTransform>();
        //maxWidth = hpTran.rect.width;
        //Debug.Log(maxWidth);
    }

    // Update is called once per frame
    void Update()
    {
        hpTran.localScale = new Vector3(hp / (float)mhp, 1, 1);
    }
}
