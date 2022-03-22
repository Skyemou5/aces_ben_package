using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

public class ExplodeBehavior : MonoBehaviour
{
    public float minForce, maxForce, radius;
    [SerializeField] private GameObject target;

    public UnityEvent explode;

    //private Rigidbody rb;
    private void Start()
    {
        Explode(target);
    }

    private void OnEnable()
    {
        foreach (Transform t in target.transform)
        {
            var rb = t.GetComponent<Rigidbody>();
            if (rb = null)
            {
                Rigidbody lrb = t.gameObject.AddComponent<Rigidbody>();
            }
        }
    }

    public void Explode(GameObject o)
    {
        foreach (Transform t in o.transform)
        {
            var rb = t.GetComponent<Rigidbody>();
            if (rb != null)
            {
                    rb.AddExplosionForce(Random.Range(minForce, maxForce), transform.position, radius);
            }
            
        }

    }

    public void triggerEvent()
    {
        if (Input.GetKeyDown("space"))
        {
            explode?.Invoke();
        }
    }
}
