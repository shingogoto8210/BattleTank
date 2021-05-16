using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDestoryItem : MonoBehaviour
{
    private TankHealth th;
    private int motonoHP;
    private int starcount;
    [SerializeField] private AudioClip getSound;
    [SerializeField] private GameObject effectPrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            th = GameObject.Find("Tank").GetComponent<TankHealth>();
            motonoHP = th.tankHP;
            starcount = 20;
            th.tankHP += 10000;
            InvokeRepeating("mutekijikan", 0f, 1f);
            th.tankHP = motonoHP;
            th.HpLabel.text = "HP:" + th.tankHP;
            
        }
    void mutekijikan()
        {
            if (starcount > 0)
            {
                th.HpLabel.text = "むてきあと" + starcount + "秒";
                starcount -= 1;
            }

            AudioSource.PlayClipAtPoint(getSound, transform.position);
            GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);
            Destroy(effect, 0.5f);
        }
    }
}
