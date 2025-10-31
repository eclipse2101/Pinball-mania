using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlapScript : MonoBehaviour
{
    private float flapup;
    private float flapdown;

    // Start is called before the first frame update
    void Awake()
    {
        if(gameObject.CompareTag("Left Flap"))
        {
            Debug.Log("This is left flap");
        }
        else if(gameObject.CompareTag("Right Flap"))
        {
            Debug.Log("This is Right flap");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void FlapUp()
    {

    }

    public void FlapDown()
    {

    }
}
