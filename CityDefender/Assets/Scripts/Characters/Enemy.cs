using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    


    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject otherGO = collision.gameObject;
        if(otherGO.tag == "CityIsReached" || otherGO.tag == "Player")
        {
            
            Time.timeScale = 0;
            
        }

    }

   


}
