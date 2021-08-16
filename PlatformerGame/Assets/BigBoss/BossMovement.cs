using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
  public float speed = -5f;
    public Rigidbody2D rb;
    public float timer = 8f;
    // Start is called before the first frame update
    void Update()
    {
        timer -= Time.deltaTime;

        rb.velocity = transform.right * speed;

        if(timer <= 0){
            transform.Rotate (0f, 180f, 0f);
            timer = 8f;
        }
        
        
        
    }


    IEnumerator directionPause() {
        

        yield return new WaitForSeconds(2.5f);

        
    }
}
