using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private UIManager _uiManager;
    

    private void Start()
    {
        // Assuming UIManager is on a different GameObjec
        _uiManager = FindObjectOfType<UIManager>();
        Destroy(gameObject, 2);

    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otherGO = collision.gameObject;
        if (otherGO.tag == "Player")
        {
            _uiManager.OnDeathShowPanel();
            Time.timeScale = 0;
        }
    }
}
