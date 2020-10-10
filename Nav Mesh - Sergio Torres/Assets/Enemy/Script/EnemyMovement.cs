using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform[] points;
    int destPoint = 0;
    private NavMeshAgent myNav;
    float playPos;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        myNav = GetComponent<NavMeshAgent>();
        myNav.autoBraking = false;
        nextPoint();
    }

    void nextPoint()
    {
        if (points.Length == 0)
            return;

        myNav.destination = points[destPoint].position;
        destPoint = (destPoint + 1) % points.Length;
    }

    // Update is called once per frame
    void Update()
    {
        playPos = Vector3.Distance(player.transform.position, transform.position);
        //Debug.Log("position: " + playPos);
        if (playPos < 2.5)
        {
            myNav.SetDestination(player.transform.position);
        }

        if (!myNav.pathPending && myNav.remainingDistance < 0.5f)
        {
            nextPoint();
        }
    }
}
