using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneWait : MonoBehaviour
{

    public float time;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(nextScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator nextScene() {
         yield return new WaitForSeconds(time);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
