using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float _livingTime;

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Renderer>().material.color = Color.red;
        LivingTime();
    }

    private void LivingTime()
    {
        Destroy(gameObject, _livingTime);
    }
}
