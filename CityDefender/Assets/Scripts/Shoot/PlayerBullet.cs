using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        GameObject otherGO = collision.gameObject;

        if(otherGO.tag == "Enemy")
        {
            Destroy(otherGO);
        }
    }
}
