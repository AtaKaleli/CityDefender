using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject _enemyPrefab;
    private float yCoordinate = 6.78f;


    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }
    void Update()
    {
        
        
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            Instantiate(_enemyPrefab, new Vector3(12.62f, Random.Range(-yCoordinate, yCoordinate), 0), Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
       
    }
}
