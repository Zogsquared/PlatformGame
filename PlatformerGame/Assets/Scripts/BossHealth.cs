using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
 
    public int maxHealth = 100;
    public int currentHealth;

    //public AudioSource[] sounds;
    //public AudioSource noise2;

    public Healthbar healthbar;

    // Start is called before the first frame update
    void Start()
    {
        //sounds = GetComponents<AudioSource>();
        //noise2 = sounds[1];

        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void OnTriggerEnter2D (Collider2D hitInfo) 
    {
        if (GameObject.FindGameObjectWithTag("Bullet") == true) {
            TakeDamage(20);
        }
        if (currentHealth <= 0) {
            Destroy(gameObject);
            //Destroy(gameObject);
        }
    }

    void TakeDamage(int damage) {
        currentHealth -= damage;
        //noise2.Play();

        healthbar.SetHealth(currentHealth);
    }
}
