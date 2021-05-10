﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseCamera : MonoBehaviour
{
    [SerializeField] private GameObject target;
    private Vector3 offset;
    
    void Start()
    {
        //カメラとターゲットの最初の位置関係を（距離）を取得する
        offset = transform.position - target.transform.position;
    }

    void Update()
    {
        if(target != null)
        {
            //最初に取得した位置関係を足すことで常に一定の距離を維持する
            transform.position = target.transform.position + offset;
        }
    }
}
