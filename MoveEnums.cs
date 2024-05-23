namespace MoveEnums {

    // Combinations of buttons that can be pressed at the same time and will mean something
    public enum FrameInput {

        Light,      //Implemented
        Medium,     //Implemented
        Heavy,      //Implemented
        Imprint,    //Implemented
        LightMedium,//Implemented
        LightHeavy, 
        MediumHeavy,//Implemented
        LightImprint,
        MediumImprint,
        HeavyImprint,//Implemented
        LightMediumHeavy,//Implemented
        LightMediumHeavyImprint,//Implemented
        NoInput,        //Implemented

        // Command Inputs
        // We do directions using numpade notation
    }

    public enum CompleteInput {

        QCF_Light,
        QCF_Medium,
        QCF_Heavy,
        QCF_Imprint,

        QCB_Light,
        QCB_Medium,
        QCB_Heavy,
        QCB_Imprint,

        DP_Light,
        DP_Medium,
        DP_Heavy,
        DP_Imprint,

        // DD == DownDown
        DD_Light,
        DD_Medium,
        DD_Heavy,
        DD_Imprint,

        // CLR == Charge Left Right
        CLR_Light,
        CLR_Medium,
        CLR_Heavy,
        CLR_Imprint,

        // CUD == Charge Up Down
        CUD_Light,
        CUD_Medium,
        CUD_Heavy,
        CUD_Imprint,

        // MOVEMENT INPUTS

        FF,  // FF == Forward Forward
        WF, // Walk Forward
        BB, // BB == Back Back
        NJ, // Neutral Jump
        FJ, // Forward Jump
        BJ, // Backwards Jump

        // Block
    }

    // For which direction they are facing
    public enum Direction {
        Left,
        Right,
    }
}
