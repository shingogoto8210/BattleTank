using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAllEnemyItem : MonoBehaviour
{
    private GameObject[] targets;

    [SerializeField] private AudioClip getSound;
    [SerializeField] private GameObject effectPrefab;
    [SerializeField] private GameObject effectPrefab2;

    private void Update()
    {

        targets = GameObject.FindGameObjectsWithTag("Enemy");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(getSound, transform.position);
            GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);
            Destroy(effect, 0.5f);
            for (int i = 0; i < targets.Length; i++)
            {
                Destroy(targets[i]);
                GameObject effect2 = Instantiate(effectPrefab2, targets[i].transform.position, Quaternion.identity);
                Destroy(effect2, 0.5f);
            }
        }
    }
}
