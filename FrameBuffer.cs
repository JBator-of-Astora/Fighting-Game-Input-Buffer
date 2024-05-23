using MoveEnums;
using System.Collections.Generic;
using UnityEngine;

public class FrameBuffer
{

    
    // Controls how many frames someone has to input a move
    int bufferSize = 10;
    private List<(FrameInput, int)> buffer;
    
    public FrameBuffer() {

        buffer = new List<(FrameInput, int)>();

        for (int i = 0; i < bufferSize; i++) {

            buffer.Add((FrameInput.NoInput, 5));
        }
    }
    
    public CompleteInput processFrame(bool left, bool right, bool up, bool down, bool light, bool medium, bool heavy, bool imprint, Direction direction) {

        shuffle_buffer();
        (FrameInput, int ) value = get_frame_input(left, right, up, down, light, medium, heavy, imprint, direction);

        Debug.Log(value);
        return CompleteInput.DD_Heavy;
    }
    

    private CompleteInput interpret_complete_input() {

        return CompleteInput.DD_Heavy;
    } 
    private (FrameInput, int) get_frame_input(bool left, bool right, bool up, bool down, bool light, bool medium, bool heavy, bool imprint, Direction directionFace) {

        FrameInput attackButton = FrameInput.NoInput;
        int direction = 0;
        
        // Going through numpad notation starting at 1       
        switch ((left, right, up, down, directionFace)) {
            
            // Each set of cases has one for facing right and one for facing left. 
            // Would like to come back to this with generic cases for things like down that are the same left or right
            // 1
            case (true, false, false, true, Direction.Right):
                direction = 1;
                break;
            case (false, true, false, true, Direction.Left):
                direction = 1;
                break;
            // 2
            case (false, false, false, true, Direction.Right):
                direction = 2;
                break;
            case (false, false, false, true, Direction.Left):
                direction = 2;
                break;

            // 3
            case (false, true, false, true, Direction.Right):
                direction = 3;
                break;
            case (true, false, false, true, Direction.Left):
                direction = 3;
                break;

            // 4
            case (true, false, false, false, Direction.Right):
                direction = 4;
                break;
            case (false, true, false, false, Direction.Left):
                direction = 4;
                break;

            // 5
            case (false, false, false, false, Direction.Right):
                direction = 5;
                break;
            case (false, false, false, false, Direction.Left):
                direction = 5;
                break;
             
            // 6
            case (false, true, false, false, Direction.Right):
                direction = 6;
                break;
            case (true, false, false, false, Direction.Left):
                direction = 6;
                break;
            
            // 7
            case (true, false, true, false, Direction.Right):
                direction = 7;
                break;
            case (false, true, true, false, Direction.Left):
                direction = 7;
                break;

            // 8 
            case (false, false, true, false, Direction.Right):
                direction = 8;
                break;
            case (false, false, true, false, Direction.Left):
                direction = 8;
                break;

            // 9
            case (false, true, true, false, Direction.Right):
                direction = 9;
                break;
            case (true, false, true, false, Direction.Left):
                direction = 9;
                break;

        }

        switch ((light, medium, heavy, imprint)) {

            case (true, false, false, false):
                attackButton = FrameInput.Light;
                break;

            case (false, true, false, false):
                attackButton = FrameInput.Medium;
                break;
            
            case (false, false, true, false):
                attackButton = FrameInput.Heavy;
                break;

            case (false, false, false, true):
                attackButton = FrameInput.Imprint;
                break;

            case (true, true, false, false):
                attackButton = FrameInput.LightMedium;
                break;

            case (false, true, true, false):
                attackButton = FrameInput.MediumHeavy;
                break;
            
            case (false, false, true, true):
                attackButton = FrameInput.HeavyImprint;
                break;

            case (true, true, true, false):
                attackButton = FrameInput.LightMediumHeavy;
                break;

            case (true, true, true, true):
                attackButton = FrameInput.LightMediumHeavyImprint;
                break;
        }

       return (attackButton, direction);
    }
    
    private void shuffle_buffer() {

        for (int i = bufferSize - 1; i > 0; i--) {

            buffer[i - 1] = buffer[i];
        }
    }  
}
