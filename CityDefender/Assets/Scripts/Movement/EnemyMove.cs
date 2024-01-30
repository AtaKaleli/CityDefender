using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private float _enemyMoveSpeed = 3;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * _enemyMoveSpeed;
    }
}
