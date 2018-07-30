using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{

    public Transform Girl;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - Girl.position;
    }

    void Update()
    {
        transform.position = offset + Girl.position;
    }
}  
