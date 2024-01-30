using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject _enemyBulletPref;
    public float _flingForce = 500;
    private float _timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if(_timer > 2)
        {
            GameObject enemyBullet = Instantiate(_enemyBulletPref, transform.position + new Vector3(-0.5f, 0, 0), Quaternion.identity);
            Rigidbody2D bulletRB = enemyBullet.GetComponent<Rigidbody2D>();
            bulletRB.AddForce(new Vector2(-_flingForce, 0));
            _timer = 0;
        }
        
        
        
    }
}
