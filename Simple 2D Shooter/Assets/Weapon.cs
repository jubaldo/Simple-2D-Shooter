using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {
    public Transform firepoint;
    public GameObject bulletPre;
    
	// Use this for initialization
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
	}
	
	// Update is called once per frame
	void Shoot () {
        Instantiate(bulletPre, firepoint.position, firepoint.rotation);
	}
}
