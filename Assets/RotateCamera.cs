using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField] private Transform rotationPoint;
    [SerializeField] private float rotationSpeed = 10f;

    private void Update()
    {
        transform.RotateAround(rotationPoint.position, Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
