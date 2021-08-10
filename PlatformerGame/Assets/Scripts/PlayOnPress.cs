using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnPress : MonoBehaviour
{

    [SerializeField]
    AudioSource crouching;
    
    // Start is called before the first frame update
    void Start()
    {
        AudioListener.pause = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Vertical") && Input.GetAxis("Vertical") < 0) {
            AudioListener.pause = false;
        } else if (Input.GetButtonUp("Vertical")) {
            AudioListener.pause = true;
        }
    }
}
