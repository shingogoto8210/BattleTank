using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotShell : MonoBehaviour
{
    public float shotSpeed;
    [SerializeField] private GameObject shellPrefab;
    [SerializeField] private AudioClip shotSound;
    private bool canshot;
    private float timer;
    public int shotCount;
    [SerializeField] private Text shellLabel;
    public int shotMaxCount = 20;


    private void Start()
    {
        shellLabel.text = "砲弾：" + shotCount;
        shotCount = shotMaxCount;
    }
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
            shellLabel.text = "砲弾：" + shotCount;
            timer = 0;
            canshot = false;
        }
    }

    public void Addshell(int amount)
    {
        shotCount += amount;

        if(shotCount > shotMaxCount)
        {
            shotCount = shotMaxCount;
        }
    }
}
