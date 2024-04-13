using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] ethics;
    public GameObject[] badEthics;
    public float xBounds, yBound;
    public float minSpawnInterval = 2f;
    public float maxSpawnInterval = 5f;
    public float gravityScale = 1f; // Adjust the gravity scale for falling speed
    public float spawnVelocity = -1f; // Adjust the spawn velocity

    float timeSinceLastSpawn;

    void Start()
    {
        timeSinceLastSpawn = 0f;
    }

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= Random.Range(minSpawnInterval, maxSpawnInterval))
        {
            SpawnRandomObject();
            timeSinceLastSpawn = 0f; // Reset the timer
        }

        foreach (Transform child in transform)
        {
            if (child.position.y < -6f)
            {
                Destroy(child.gameObject);
            }
        }
    }

    void SpawnRandomObject()
    {
        if (Random.value <= 0.6f)
        {
            int randomIndex = Random.Range(0, ethics.Length);
            GameObject obj = Instantiate(ethics[randomIndex], new Vector2(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);
            ApplyGravityAndVelocity(obj);
        }
        else
        {
            int randomIndex = Random.Range(0, badEthics.Length);
            GameObject obj = Instantiate(badEthics[randomIndex], new Vector2(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);
            ApplyGravityAndVelocity(obj);
        }
    }

    void ApplyGravityAndVelocity(GameObject obj)
    {
        Rigidbody2D rb = obj.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.gravityScale = gravityScale; // Apply the specified gravity scale
            rb.velocity = new Vector2(0f, spawnVelocity); // Set the spawn velocity
        }
        else
        {
            Debug.LogWarning("Rigidbody2D component not found on the spawned object.");
        }
    }
}
