using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon2 : MonoBehaviour
{
   public Transform firepoint;
    public GameObject bulletPrefab;
    
    public float Timer;

    // Update is called once per frame
    void Update() {

        Timer -= Time.deltaTime;

     if (Timer <= 0f)
     {
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        
         Timer = 2f;
     }
    }


   
}
