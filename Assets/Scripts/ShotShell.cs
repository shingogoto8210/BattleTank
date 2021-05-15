using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotShell : MonoBehaviour
{
    public float shotSpeed;
    [SerializeField] private GameObject shellPrefab;
    [SerializeField] private AudioClip shotSound;
    private bool canshot;
    private float timer;
    public int shotCount;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0.3f)
        {
            canshot = true;
        }

        if (Input.GetKeyDown(KeyCode.Space)&& canshot == true && shotCount > 0)
        {
            GameObject shell = Instantiate(shellPrefab, transform.position, Quaternion.identity);
            Rigidbody shellRb = shell.GetComponent<Rigidbody>();
            shellRb.AddForce(transform.forward * shotSpeed);
            Destroy(shell, 3.0f);
            AudioSource.PlayClipAtPoint(shotSound, transform.position);
            shotCount -= 1;
            timer = 0;
            canshot = false;
        }


    }
}
