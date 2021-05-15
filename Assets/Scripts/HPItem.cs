using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPItem : MonoBehaviour
{
    [SerializeField] private AudioClip getSound;
    [SerializeField] private GameObject effectPrefab;

    private TankHealth th;
    private int reward = 3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            th = GameObject.Find("Tank").GetComponent<TankHealth>();

            th.AddHp(reward);

            Destroy(gameObject);

            AudioSource.PlayClipAtPoint(getSound, transform.position);

            GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);

            Destroy(effect, 0.5f);
        }
    }
}
