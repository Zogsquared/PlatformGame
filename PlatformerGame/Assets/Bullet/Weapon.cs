using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    public GameObject particle;
    public Transform particleT;

    public PlayerMovement player;

    public float Timer;
    public float Cooldown;

    // Update is called once per frame
    void Update()
    {
        Timer -= 1 * Time.deltaTime;
        if (Input.GetButtonDown("Fire1") && Timer <= 0) {
            Shoot();
            StartCoroutine(player.attackWait());
            Timer = Cooldown;
        }
    }

    void Shoot () {
        // shooting logic
        StartCoroutine(attackWait1());
        
    }


    IEnumerator attackWait1() {
         
        yield return new WaitForSeconds(1f);
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        Instantiate(particle, firepoint.position, particleT.rotation);
        

    }
}
