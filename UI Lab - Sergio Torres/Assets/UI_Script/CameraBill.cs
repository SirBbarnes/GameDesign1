using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBill : MonoBehaviour
{
    public Camera m_cam;
    public RectTransform tran;
    public GameObject play;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tran.transform.LookAt(transform.position + m_cam.transform.rotation * Vector3.forward, m_cam.transform.rotation * Vector3.up);
        tran.transform.position = new Vector3(play.transform.position.x, play.transform.position.y + 1, play.transform.position.z);
    }
}
