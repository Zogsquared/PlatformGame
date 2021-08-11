using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    public AudioSource[] sounds;
    public AudioSource noise2;

    public Healthbar healthbar;

    // Start is called before the first frame update
    void Start()
    {
        sounds = GetComponents<AudioSource>();
        noise2 = sounds[1];

        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void OnTriggerEnter2D (Collider2D hitInfo) 
    {
        if (GameObject.FindGameObjectWithTag("Player") == true) {
            TakeDamage(20);
        }
        if (currentHealth == 0) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //Destroy(gameObject);
        }
    }

    void TakeDamage(int damage) {
        currentHealth -= damage;
        noise2.Play();

        healthbar.SetHealth(currentHealth);
    }
}
