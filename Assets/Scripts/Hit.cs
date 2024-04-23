using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{


    void OnCollisionEnter(Collision theObject) 
    {
        if(theObject.gameObject.name=="coconut") 
        {
            GetComponent<Animator>().SetTrigger("hit");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
