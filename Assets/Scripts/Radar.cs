using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar : MonoBehaviour
{
    [SerializeField] private Transform target;

    //「OnTriggerStay」はトリガーが他のコライダーに触れている間中実行されるメソッド
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            //「root」を使うと「親」の情報を取得ることができる
            //LookAt（）メソッドは指定した方向にオブジェクトの向きを回転させることができる
            transform.root.LookAt(target);
        }
    }
}
