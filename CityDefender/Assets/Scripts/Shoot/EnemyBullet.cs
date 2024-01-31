using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
   
    
    private void Start()
    {
        Destroy(gameObject, 2);
        
        
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otherGO = collision.gameObject;
        if(otherGO.tag == "Player")
        {

            
            Time.timeScale = 0;

        }
    }
}
