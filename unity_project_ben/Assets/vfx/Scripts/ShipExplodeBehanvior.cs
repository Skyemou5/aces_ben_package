using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShipExplodeBehanvior : MonoBehaviour
{
    [SerializeField]
    private simple_vfx_data _explodeEffect;
    
    

    
    public void Explode(InputAction.CallbackContext context)
    {
        Debug.Log(context);
        _explodeEffect.effect.Play();
    }
    
}
