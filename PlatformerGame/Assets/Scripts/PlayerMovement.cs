using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 25f;


    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    bool attack1 = false;

    // Update is called once per frame
    void Update()
    {

     horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

     animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

     if (Input.GetButtonDown("Jump")) {
         jump = true;
         animator.SetBool("isJumping", true);
     }

     if (Input.GetButtonDown("Fire1")) {
         StartCoroutine(attackWait());
     }

     if (Input.GetButtonDown("Vertical") && Input.GetAxis("Vertical") < 0) {
         crouch = true;
     } else if (Input.GetButtonUp("Vertical")) {
         crouch = false;
     }

    }

    public void OnLanding () {
        animator.SetBool("isJumping", false);
    }

    public void OnCrouching (bool isCrouching) {
        animator.SetBool("isCrouching", isCrouching);
    }

    IEnumerator attackWait() {
        attack1 = true;
        animator.SetBool("isAttack1", true);
        GetComponent<AudioSource>().Play();

        runSpeed = 0f;
         
        yield return new WaitForSeconds(2.5f);

        runSpeed = 25f;

        attack1 = false;
        animator.SetBool("isAttack1", false);
    }



    void FixedUpdate () 
    {

        //move character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
