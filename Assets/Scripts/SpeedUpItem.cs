using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpItem : MonoBehaviour
{
    [SerializeField] private AudioClip getSound;
    [SerializeField] private GameObject effectPrefab;

    private TankMovement tm;
    private float reward = 5.0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            tm = GameObject.Find("Tank").GetComponent<TankMovement>();

            tm.moveSpeed += reward;

            Destroy(gameObject);

            AudioSource.PlayClipAtPoint(getSound, transform.position);

            GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);

            Destroy(effect, 0.5f);
        }
    }
}
