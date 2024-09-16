using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] spawnPosition;
    [SerializeField] private GameObject[] prefabs;

    private void Start()
    {
        StartCoroutine(ObstacleSpawner());
    }

    private IEnumerator ObstacleSpawner()
    {
        int countObjects = Random.Range(1, 4);

        for (int i = 0; i < countObjects; i++)
        {
            int randomPosition = Random.Range(0, spawnPosition.Length);
            int randomPrefab = Random.Range(0, prefabs.Length);
            Vector3 spawnVector = spawnPosition[randomPosition].position;
            Instantiate(prefabs[randomPrefab], spawnVector, Quaternion.identity);
        }

        yield return new WaitForSeconds(2f);

        StartCoroutine(ObstacleSpawner());
    }
}
