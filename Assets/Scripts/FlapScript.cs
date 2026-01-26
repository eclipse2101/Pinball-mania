using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class FlapScript : MonoBehaviour
{
    public float flapup;
    public float flapdown;
    public float rFlap;
    public float speed;

    private Vector3 vup;
    private Vector3 vdown; 
    // Start is called before the first frame update
    void Awake()
    {
        if(gameObject.CompareTag("Left Flap"))
        {
            flapdown = (int)gameObject.transform.rotation.eulerAngles.z;//330f
            flapup = 30f; //This pretty much acts as postive 30 in the inspector 
            vup = Vector3.forward;
            vdown = Vector3.back; 
            Debug.Log("This is left flap");
        }
        else if(gameObject.CompareTag("Right Flap"))
        {
            flapdown = (int)gameObject.transform.rotation.eulerAngles.z;// f30
            flapup = 330f; //This pretty much acts as postive -30 in the inspector 
            vup = Vector3.back;
            vdown = Vector3.forward;
            Debug.Log("This is Right flap");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rFlap = (int)gameObject.transform.rotation.eulerAngles.z;
        FlapU();
        
    }
     
    /*
    public void FlapMovement(InputAction.CallbackContext context)
    {
       if(context.started)
       {
            FlapU();
       }
       else
       {
            FlapD();
       }

    }
    */
    public void FlapU()
    {
        if (rFlap != flapup) // 330 > 30
            {
                transform.Rotate(vup);
            }
 
    }

    public void FlapD()
    {
        if (rFlap != flapdown)
        {
            transform.Rotate(vdown);
        }
    }
}
