using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    [SerializeField] private GameObject effectPrefab;
    public int objectHp;
    [SerializeField] private GameObject effectPrefab2;
    [SerializeField] private GameObject[] items;
    [SerializeField] private int scoreValue;
    private ScoreManager sm;

    private void Start()
    {
        sm = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Shell"))
        {
            objectHp -= 1;

            if (objectHp > 0)
            {
                Destroy(other.gameObject);
                GameObject effect = Instantiate(effectPrefab, other.transform.position, Quaternion.identity);
                Destroy(effect, 2.0f);
            }
            else
            {
                Destroy(other.gameObject);
                GameObject effect2 = Instantiate(effectPrefab2, other.transform.position, Quaternion.identity);
                Destroy(effect2, 2.0f);
                Destroy(this.gameObject);
                int x = Random.Range(0, items.Length);
                Vector3 pos = transform.position;
                sm.AddPoint(scoreValue);
                if (items.Length != 0)
                {
                    Instantiate(items[x], new Vector3(pos.x,pos.y + 0.6f,pos.z), Quaternion.identity);
                }
            }
        }
        else if(other.CompareTag("EnemyShell"))
        {
            objectHp -= 1;

            if (objectHp > 0)
            {
                Destroy(other.gameObject);
                GameObject effect = Instantiate(effectPrefab, other.transform.position, Quaternion.identity);
                Destroy(effect, 2.0f);
            }
            else
            {
                Destroy(other.gameObject);
                GameObject effect2 = Instantiate(effectPrefab2, other.transform.position, Quaternion.identity);
                Destroy(effect2, 2.0f);
                Destroy(this.gameObject);
            }
        }
    }

}

