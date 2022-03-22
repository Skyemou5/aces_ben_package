using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

[System.Serializable]
public class ShipFXModel : IShipFX
{
    [GradientUsage(true)] public Gradient EngineColors;
    
    /*
    [ColorUsageAttribute(true,true,0f,8f,0.125f,3f)]
    public Color engineColor;
    [ColorUsageAttribute(true,true,0f,8f,0.125f,3f)]
    public Color trailColor;
    [ColorUsageAttribute(true,true,0f,8f,0.125f,3f)]
    public Color explosionColor;
    */
    public VisualEffectAsset engineEffectGraph;
    public List<Transform> enginePosition;
    public GameObject engineEffect;
    public GameObject trailEffect;
    public GameObject explodeEffect;
    public GameObject damageEffect;
}

/*
[System.Serializable]
public class ShipType
{
    
}
*/
