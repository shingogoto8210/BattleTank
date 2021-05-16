using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAttackItem : MonoBehaviour
{
    private GameObject[] targets;
    [SerializeField] private AudioClip getsound;
    [SerializeField] private GameObject effectprefab;

    private void Update()
    {
        targets = GameObject.FindGameObjectsWithTag("EnemyShotShell");

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            for(int i = 0; i< targets.Length; i++)
            {
                targets[i].GetComponent<EnemyShotShell>().AddStopTimer(3.0f);
            }
        }
        Destroy(gameObject);
        GameObject effect = Instantiate(effectprefab,transform.position, Quaternion.identity);
        Destroy(effect, 1.0f);
        AudioSource.PlayClipAtPoint(getsound,transform.position);

    }
}
