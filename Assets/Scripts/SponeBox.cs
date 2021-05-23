using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SponeBox : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    private int interval; 
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        interval += 1;
        if(interval % 60 == 0)
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }
}
