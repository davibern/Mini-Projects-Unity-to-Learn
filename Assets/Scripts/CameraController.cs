using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _target;

    void Update()
    {
        // Look the gameobject targeted
        transform.LookAt(_target);
    }
}
