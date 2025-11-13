using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlapScript : MonoBehaviour
{
    public float flapup;
    public float flapdown;
    public float rFlap;

    // Start is called before the first frame update
    void Awake()
    {
        if(gameObject.CompareTag("Left Flap"))
        {
            flapdown = (int)gameObject.transform.rotation.eulerAngles.z;
            flapup = 30f; //This pretty much acts as postive 30 in the inspector 
            Debug.Log("This is left flap");
        }
        else if(gameObject.CompareTag("Right Flap"))
        {
            flapdown = (int)gameObject.transform.rotation.eulerAngles.z;
            flapup = 330f; //This pretty much acts as postive -30 in the inspector 
            Debug.Log("This is Right flap");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
           rFlap = (int)gameObject.transform.rotation.eulerAngles.z;
    }
    
    public void FlapU()
    {

    }

    public void FlapD()
    {

    }
}
