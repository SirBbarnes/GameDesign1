using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelControl : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    bool switchState;

    public void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {

        if (switchState == true)
        {
            SceneManager.LoadScene(1);
            p1.SetActive(false);
            p2.SetActive(false);
            p3.SetActive(false);
            switchState = false;

        }

    }

    public void ButtonStart()
    {
        switchState = true;
    }

    public void SetPanel(int p)
    {
        switch(p)
        {
            case 0:
                p1.SetActive(true);
                p2.SetActive(false);
                p3.SetActive(false);
                break;

            case 1:
                p1.SetActive(false);
                p2.SetActive(true);
                p3.SetActive(false);
                break;

            case 2:
                p1.SetActive(false);
                p2.SetActive(false);
                p3.SetActive(true);
                break;

            default:
                break;
        }
    }
}
