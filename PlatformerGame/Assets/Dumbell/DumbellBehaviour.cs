using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DumbellBehaviour : MonoBehaviour
{
    public float speed = -20f;
    public float timer = 5f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        //_spriteRenderer.sprite =  sprites[Random.Range(0, sprites.Length)];
        rb.velocity = transform.right * speed;
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer <= 0){
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D (Collider2D hitInfo) {
        if (hitInfo.tag == "Player") {
            Destroy(gameObject);
        }
      
  }
}
