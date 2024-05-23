using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

using MoveEnums;
public class InputHandler : MonoBehaviour
{
    private FrameBuffer buffer;
    // BUTTONS
    /*
        Light 
        Medium
        Heavy
        Imprint

        Left 
        Right 
        Up 
        Down
    */

    bool light = false;
    bool medium = false;
    bool heavy = false;
    bool imprint = false;

    bool left = false;
    bool right = false;
    bool up = false;
    bool down = false;

    Direction direction = Direction.Right;
    
    void Start()
    {
        
        buffer = new FrameBuffer();
    }

    void FixedUpdate() {

        buffer.processFrame(left, right, up, down, light, medium, heavy, imprint, direction);
        reset_attack_buttons();
    }

    private void reset_attack_buttons() {

        light = false;
        medium = false;
        heavy = false;
        imprint = false;
    }

    public void WestButton(InputAction.CallbackContext context) {

        if (context.performed) {

            light = true;
        }
    }

    public void NorthButton(InputAction.CallbackContext context) {

        if (context.performed) {

            medium = true;
        }
    }
    public void EastButton(InputAction.CallbackContext context) {

        if (context.performed) {

            heavy = true;
        }
    }

    public void SouthButton(InputAction.CallbackContext context) {

        if (context.performed) {

            imprint = true;
        }
    }

    // D-Pad Buttons
    public void LeftButton(InputAction.CallbackContext context) {

        if (context.performed) {

            left = true;
        } else if (context.canceled) {

            left = false;
        }
    }

    public void RightButton(InputAction.CallbackContext context) {

        if (context.performed) {

            right = true;
        } else if (context.canceled) {

            right = false;
        }
    }

    public void UpButton(InputAction.CallbackContext context) {

         if (context.performed) {

            up = true;
        } else if (context.canceled) {

            up = false;
        }
    }

    public void DownButton(InputAction.CallbackContext context) {

        if (context.performed) {

            down = true;
        } else if (context.canceled) {

            down = false;
        }
    }
}
