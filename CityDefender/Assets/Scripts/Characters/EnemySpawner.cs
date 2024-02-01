using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject _enemyPrefab;
    private float yCoordinate = 6.78f;
    private float _timer;
    private float _spawnSpeed;
    private bool flag;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }
    void Update()
    {
        _timer += Time.deltaTime;

    }

    IEnumerator SpawnEnemy()
    {
        
        while (true)
        {

            _spawnSpeed = _timer / 25;
            Instantiate(_enemyPrefab, new Vector3(12.62f, Random.Range(-yCoordinate, yCoordinate), 0), Quaternion.identity);
            
            if(4f < (_timer / 25))
            {
              _spawnSpeed = 4f;
              
            }
            
            yield return new WaitForSeconds(4f - _spawnSpeed + 0.7f);
        }
       
    }
}
