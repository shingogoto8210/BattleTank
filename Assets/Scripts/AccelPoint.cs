using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 20),ForceMode.VelocityChange);
    }
}
