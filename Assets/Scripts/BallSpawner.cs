using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab; // Reference to the prefab of the ball
    public GameObject bucket; // Reference to the GameObject representing your bucket
    public float spawnHeight = 1.0f; // Height above the bucket to spawn the ball

    public void SpawnBall()
    {
        // Check if the bucket GameObject is assigned
        if (bucket != null)
        {
            // Calculate the spawn position above the bucket
            Vector3 spawnPosition = bucket.transform.position + Vector3.up * spawnHeight;

            // Spawn the ball at the calculated position
            Instantiate(ballPrefab, spawnPosition, Quaternion.identity);
        }
        else
        {
            Debug.LogError("Bucket GameObject is not assigned!");
        }
    }
}
