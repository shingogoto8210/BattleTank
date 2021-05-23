using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChaseEnemy : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.Find("Tank");
    }

    // Update is called once per frame
    void Update()
    {
        if(target != null)
        {
            //ターゲットの一を目的地に設定する
            agent.destination = target.transform.position;
        }
    }
}
