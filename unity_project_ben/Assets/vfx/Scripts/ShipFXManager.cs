using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShipFXManager : MonoBehaviour
{
    private ShipFXModel m;
    public SO_ShipFX ShipData;
    
    public enum EngineStates
    {
        OFF,
        IDLE,
        BOOST,
        OVERHEAT,
    }

    public enum ShipStates
    {
        HEALTH,
        DAMAGED,
        DESTROYED,
    }
    
    
    
}

public class ShipFXInit<T> where T : ShipFXModel {
    
}