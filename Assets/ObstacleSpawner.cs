using UnityEngine;

public class ObstacleSpawner : MonoBehaviour 
{
    public GameObject obstaclePrefab;
    public float spawnInterval = 2f;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval) 
        {
            SpawnObstacle();
            timer = 0f;
       
        }
    }

    void SpawnObstacle () 
    {
        float randomY = Random.Range(-0.5f, 1f);
        Vector3 spawnPos = new Vector3(transform.position.x, randomY, 0);
        Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
    }
}
