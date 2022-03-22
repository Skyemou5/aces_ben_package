using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class GameEventData
{
    private List<GameEventListener> listeners = new List<GameEventListener>();
 
    public virtual void Raise()
    {
        for(int i = listeners.Count -1; i >= 0; i--)
            listeners[i].OnEventRaised();
    }
 
    public virtual void RegisterListener(GameEventListener listener) => listeners.Add(listener);
 
    public virtual void UnregisterListener(GameEventListener listener) => listeners.Remove(listener);
}
