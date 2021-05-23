using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpPoint : MonoBehaviour
{
    [SerializeField] private GameObject[] warpObs;
    private void OnTriggerEnter(Collider other)
    {
        int x = Random.Range(0, warpObs.Length);
        other.gameObject.transform.position = warpObs[x].transform.position;
    }
}
