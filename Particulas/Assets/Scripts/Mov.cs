using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov : MonoBehaviour {
    Rigidbody rgb;
    bool pressForwad;
	void Start () {
        rgb = GetComponent<Rigidbody>();
        pressForwad = false;

	}

    void FixedUpdate()
    {
        if (pressForwad == true)
        {
            rgb.AddRelativeForce(-Vector3.forward, ForceMode.Impulse);
        }
    }
    void Update () {
		if (Input.GetKey(KeyCode.W))
        {
            pressForwad = true;
        }
	}
}
