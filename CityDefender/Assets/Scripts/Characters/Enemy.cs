using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private UIManager _uiManager;
    private void Start()
    {
        // Assuming UIManager is on a different GameObjec
        _uiManager = FindObjectOfType<UIManager>();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject otherGO = collision.gameObject;
        if(otherGO.tag == "CityIsReached" || otherGO.tag == "Player")
        {
            _uiManager.OnDeathShowPanel();
            Time.timeScale = 0;
            
        }

    }

   


}
