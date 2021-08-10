using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    //private SpriteRenderer _spriteRenderer;
    //public Sprite[] sprites;

    public float timer = 2f;

    private void Awake() 
    {
       //_spriteRenderer =GetComponent<SpriteRenderer>(); 
       rb = GetComponent<Rigidbody2D>();
    }

    public float speed = 20f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        //_spriteRenderer.sprite =  sprites[Random.Range(0, sprites.Length)];
        rb.velocity = transform.right * speed;
        
    }

    public static void KillEnemy (enemyDelete enemy) {
        Destroy (enemy.gameObject);
    }
   
    void OnTriggerEnter2D (Collider2D hitInfo) {
        
        Debug.Log(hitInfo.name);
        //Destroy(gameObject);
            
    }

    void Update()
    {
       
        timer -= Time.deltaTime;

        if(timer <= 0){
            Destroy(gameObject);
        }
    } 
}
