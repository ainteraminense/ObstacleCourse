using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    public float timeToWait = 3f;
    MeshRenderer renderer;
    Rigidbody rigidbody;
    private void Awake()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        renderer.enabled = false;
        rigidbody.useGravity = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
