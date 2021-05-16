using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllEnemyDestroyItem : MonoBehaviour
{
    public GameObject enemyA;
    public GameObject enemyB;

    [SerializeField] private AudioClip getSound;
    [SerializeField] private GameObject effectPrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(enemyA);
            Destroy(enemyB);
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(getSound, transform.position);
            GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);
            Destroy(effect, 0.5f);
        }
    }
}
