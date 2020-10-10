using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerScript : MonoBehaviour
{
    Vector3 goal1;
    Vector3 goal2;
    NavMeshAgent myNav = null;
    public int goal = 0;

    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
        myNav = this.gameObject.GetComponent<NavMeshAgent>();
        goal1 = GameObject.Find("Goal1").transform.position;
        goal2 = GameObject.Find("Goal2").transform.position;
        myNav.destination = goal1;
        myNav.Resume();
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if (myNav.remainingDistance == 0 && goal == 0)
        {
            goal++;
            myNav.destination = goal2;
            myNav.Resume();
        }
    }
}
