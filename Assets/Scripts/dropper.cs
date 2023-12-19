using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropper : MonoBehaviour
{
    MeshRenderer render;
    Rigidbody rb;
    [SerializeField] float timetowait = 5f;
    void Start()
    {
        render = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
        render.enabled = false;
        rb.useGravity = false;
    }
    // Update is called once per frame
    void Update()
    {
        if(Time.time > timetowait)
        {
            render.enabled = true;
            rb.useGravity = true;
        }
    }
}
