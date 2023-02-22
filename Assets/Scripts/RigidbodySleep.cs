using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodySleep : MonoBehaviour
{
    // Start is called before the first frame update
    private int sleepCountdown = 4;
    private Rigidbody rigid;

    void Awake() {
        rigid = GetComponent<Rigidbody>();

    }

    void FixedUpdate() {
        if (sleepCountdown > 0) {
            rigid.Sleep();
            sleepCountdown--;
        }
    }
}
