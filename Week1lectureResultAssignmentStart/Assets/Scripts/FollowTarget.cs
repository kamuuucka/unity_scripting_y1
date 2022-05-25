﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
	public Transform target;
    public float moveSpeed;
	Vector3 offset = new Vector3(0, 0, 0);
	[Range(-1,5)]
	public float scale = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        transform.LookAt(target);
        transform.Translate(Vector3.forward * moveSpeed);
    }
}
