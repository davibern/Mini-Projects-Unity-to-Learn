using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform spawnPoint;
    [SerializeField] private GameObject _ball;
    [SerializeField] private float maxX;
    [SerializeField] private float maxZ;

    private void Start()
    {
        InvokeRepeating("SpawnBall", 1f, 2f);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBall();
        }

        if (Input.GetMouseButtonDown(0))
        {
            SpawnBallByMouseClic();
        }
    }

    private void SpawnBallByMouseClic()
    {
        // Get mouse position
        Vector3 mousePosition = Input.mousePosition;

        // Set the Z position always on 10f
        mousePosition.z = 10f;

        // Spawn the balls 
        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Instantiate(_ball, spawnPosition, Quaternion.identity);
    }

    private void SpawnBall()
    {
        float randomX = Random.Range(-maxX, maxX);
        float randomZ = Random.Range(-maxZ, maxZ);

        Vector3 randomSpawnPosition = new Vector3(randomX, 10f, randomZ);

        Instantiate(_ball, randomSpawnPosition, Quaternion.identity);
    }
}
