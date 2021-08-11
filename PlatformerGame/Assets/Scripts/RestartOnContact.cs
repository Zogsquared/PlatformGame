using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnContact : MonoBehaviour
{
    [SerializeField]
    string strTag;

   void OnTriggerEnter2D (Collider2D hitInfo) {
      
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      
  }
}
