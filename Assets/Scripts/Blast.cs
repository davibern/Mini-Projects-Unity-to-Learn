using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blast : MonoBehaviour
{
    [SerializeField] private GameObject blast;

    private void OnMouseDown()
    {
        // Spawn blast particle
        Instantiate(blast, transform.position, blast.transform.rotation);
        Destroy(gameObject);
    }
}
