using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputDeviceController : MonoBehaviour
{   
    InputDevice player1;
    InputDevice player2;

    // Start is called before the first frame update
    void Start()
    {
        
       player1 = Gamepad.all[0];   

    }

    

    // Update is called once per frame
    void Update()
    {
        
       
    }
}
