using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDelete : MonoBehaviour
{
    
    void OnTriggerEnter2D (Collider2D hitInfo) {
        if (GameObject.FindGameObjectWithTag("Bullet") == true) {
            bullet.KillEnemy(this);
        }
    }
}
