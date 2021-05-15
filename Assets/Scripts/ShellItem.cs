﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellItem : MonoBehaviour
{
    [SerializeField] private AudioClip getSound;
    [SerializeField] private GameObject effectPrefab;
    private ShotShell ss;
    private int reward = 5;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            ss = GameObject.Find("ShotShell").GetComponent<ShotShell>();

            ss.Addshell(reward);

            Destroy(gameObject);

            AudioSource.PlayClipAtPoint(getSound, transform.position);

            GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);

            Destroy(effect, 0.5f);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
