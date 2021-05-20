using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private Text scorelabel;
    private int total = 0;

    // Start is called before the first frame update
    void Start()
    {
        scorelabel.text = "Score:" + total;
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void AddPoint(int point)
    {
        total += point;
        scorelabel.text = "Score:" + total;
        
    }
}
