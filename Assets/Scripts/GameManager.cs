using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int totalCount;
    public int clearNumber;
    [SerializeField] GameObject door;
    [SerializeField] GameObject player;


    public void AddCount(int count)
    {
        totalCount += count;
        if (totalCount >= clearNumber)
        {
            Destroy(door);
        }
    }
    private void Update()
    {
        Vector3 playerPos = player.transform.position;
        if(playerPos.z >=  50)
        {
            SceneManager.LoadScene("BossStage");
        }
    }

}
