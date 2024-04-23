using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    [SerializeField] private float rotateSpeed;

    private void FixedUpdate()
    {
        transform.Rotate(Vector3.right, rotateSpeed);
    }
}
