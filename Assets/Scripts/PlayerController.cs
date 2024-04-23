using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody _rb;
    private float _xInput;
    private float _zInput;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();       
    }

    private void Update()
    {
        _xInput = Input.GetAxis("Horizontal");
        _zInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        float xVelocity = _xInput * _speed;
        float zVelocity = _zInput * _speed;

        _rb.velocity = new Vector3(xVelocity, _rb.velocity.y, zVelocity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
        }
    }
}
