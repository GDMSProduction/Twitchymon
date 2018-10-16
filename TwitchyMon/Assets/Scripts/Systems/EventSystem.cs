using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EventSystem {

    //ADD DELEGATES BASED ON THE TYPE OF FUNCTION YOU NEED AS AN EVENT

    // DELEGATES
    public delegate void VoidWithNoParams();
    public delegate bool BoolWithBoolParam(bool _bool);

    // EVENTS
    public static event VoidWithNoParams TestEvent;
    public static event VoidWithNoParams BeginBattle;

    public static void TriggerTestEvent()
    {
        if (TestEvent != null)
            TestEvent();
    }

    public static void TriggerBattle()
    {
        if (BeginBattle != null)
            BeginBattle();
    }

}
