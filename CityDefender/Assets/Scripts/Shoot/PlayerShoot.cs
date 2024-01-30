using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject _playerShootPrefab;
    
    private Rigidbody2D _rb;
    public float _flingForce = 500;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newShoot = Instantiate(_playerShootPrefab, transform.position + new Vector3(0.5f,0,0), Quaternion.identity);
            Rigidbody2D shootRB = newShoot.GetComponent<Rigidbody2D>();
            shootRB.AddForce(new Vector2(_flingForce, 0));
        }
    }
}
