using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof (AudioSource))]

public class CoconutThrower : MonoBehaviour
{
    public AudioClip throwSound;
    public Rigidbody coconutPrefab;
    public float throwSpeed = 30.0f;
    public static bool canThrow = false;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GetComponent<AudioSource>().PlayOneShot(throwSound);
            Rigidbody newCoconut = Instantiate(coconutPrefab, transform.position, transform.rotation) as Rigidbody;
            newCoconut.velocity = transform.forward * throwSpeed;
            newCoconut.name = "coconut";    

            if(Input.GetButtonUp("Fire1") && canThrow)
            {
                
            }
        }


    }
}
