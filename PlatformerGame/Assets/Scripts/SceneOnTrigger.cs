using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneOnTrigger : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D hitInfo) {
        if (GameObject.FindGameObjectWithTag("Player") == true) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
