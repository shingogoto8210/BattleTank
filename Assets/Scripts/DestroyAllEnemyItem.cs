using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAllEnemyItem : MonoBehaviour
{
    public GameObject enemyA;
    public GameObject enemyB;

    [SerializeField] private AudioClip getSound;
    [SerializeField] private GameObject effectPrefab;
    [SerializeField] private GameObject effectPrefab2;

    //破壊した後にアイテムをとったらエラーが起きる！！！！！！！！！！！

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(enemyA);
            Destroy(enemyB);
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(getSound, transform.position);
            GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);
            GameObject effect2 = Instantiate(effectPrefab2, enemyA.transform.position, Quaternion.identity);
            GameObject effect3 = Instantiate(effectPrefab2, enemyB.transform.position, Quaternion.identity);


            Destroy(effect, 0.5f);
            Destroy(effect2, 0.5f);
            Destroy(effect3, 0.5f);


        }
    }
}
