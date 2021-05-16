using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour
{
    [SerializeField] private GameObject effectPrefab1;
    [SerializeField] private GameObject effectPrefab2;
    public int tankHP;
    public Text HpLabel;
    public int HpMaxCount = 20;


    private void Start()
    {
        tankHP = HpMaxCount;
        HpLabel.text = "HP:" + tankHP;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag ("EnemyShell"))
        {
            tankHP -= 1;
            HpLabel.text = "HP:" + tankHP;

            Destroy(other.gameObject);

            if(tankHP > 0)
            {
                GameObject effect1 = Instantiate(effectPrefab1, transform.position, Quaternion.identity);
                Destroy(effect1, 1.0f);
            }
            else
            {
                GameObject effect2 = Instantiate(effectPrefab2, transform.position, Quaternion.identity);
                Destroy(effect2, 1.0f);

                //Destroy(gameObject);
                this.gameObject.SetActive(false);
                Invoke("GotoGameOver",1.5f);
            }
        }
    }

    void GotoGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    private void Update()
    {
        if (transform.position.y < -1)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    public void AddHp(int amount)
    {
        tankHP += amount;

        if (tankHP > HpMaxCount)
        {
            tankHP = HpMaxCount;
        }
        HpLabel.text = "HP:" + tankHP;

    }
}
