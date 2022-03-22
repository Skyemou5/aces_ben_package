using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    public GameEvent Event;
    public UnityEvent Response;
    
 
    private void OnEnable() => Event.Event.RegisterListener(this);
 
    private void OnDisable() => Event.Event.UnregisterListener(this);
 
    public void OnEventRaised() => Response.Invoke();
}
