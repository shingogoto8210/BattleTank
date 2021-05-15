﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotShell : MonoBehaviour
{
    public float shotSpeed;
    [SerializeField] private GameObject shellPrefab;
    [SerializeField] private AudioClip shotSound;
    public bool canshot;
    public float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1.0f)
        {
            canshot = true;
        }

        if (Input.GetKeyDown(KeyCode.Space)&& canshot == true)
        {
            GameObject shell = Instantiate(shellPrefab, transform.position, Quaternion.identity);
            Rigidbody shellRb = shell.GetComponent<Rigidbody>();
            shellRb.AddForce(transform.forward * shotSpeed);
            Destroy(shell, 3.0f);
            AudioSource.PlayClipAtPoint(shotSound, transform.position);
            timer = 0;
            canshot = false;
        }
    }
}
