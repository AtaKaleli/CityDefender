using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject _playerShootPrefab;
    
    private Rigidbody2D _rb;
    public float _flingForce = 500;
    private float _timer;
    private float _specialShootTime = 3;

    public AudioSource _singleShot;
    public AudioSource _specialShot;
    private UIManager _uiManager;
    void Start()
    {
        _uiManager = FindObjectOfType<UIManager>();
        _rb = GetComponent<Rigidbody2D>();
        _timer = _specialShootTime;
    }

    // Update is called once per frame
    void Update()
    {

        _uiManager.UpdateShotReload(_timer / _specialShootTime);
        _timer += Time.deltaTime;
        
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _singleShot.Play();
            GameObject newShoot = Instantiate(_playerShootPrefab, transform.position + new Vector3(0.5f,0,0), Quaternion.identity);
            Rigidbody2D shootRB = newShoot.GetComponent<Rigidbody2D>();
            shootRB.AddForce(new Vector2(_flingForce, 0));
        }
        else if (Input.GetKeyDown(KeyCode.F) && _timer >= _specialShootTime)
        {
            _specialShot.Play();
            for (int i = 0; i < 20; i++)
            {
                float yCoordinate = i - 9.5f;
                GameObject newShoot = Instantiate(_playerShootPrefab, transform.position + new Vector3(0.5f, yCoordinate, 0), Quaternion.identity);
                Rigidbody2D shootRB = newShoot.GetComponent<Rigidbody2D>();
                shootRB.AddForce(new Vector2(_flingForce, 0)); // Adjust the force or any other parameters as needed
            }
            _timer = 0;
        }
    }
}
