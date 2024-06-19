using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{

    public bool isPressed;

    public GameObject Cube;
    float degrees = 0;
    public float degreeChange = 45;
    
    
    public void Update() {

        if(isPressed == true)
        { 
            degrees += degreeChange * Time.deltaTime;
            Quaternion rotation = Quaternion.Euler(0, degrees, 0);

            Cube.transform.rotation = rotation;


            print("I EXIST");
        }

    }


    public void MOUSEUP()
    {
        isPressed = false;
    }

    public void MOUSEDOWN()
    {
        isPressed = true;
    }


}
