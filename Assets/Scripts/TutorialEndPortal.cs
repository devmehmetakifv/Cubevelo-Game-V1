using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TutorialEndPortal : MonoBehaviour
{
    public AudioSource aSrc;
    private int sceneNumber;
    public GameObject bgAudio;
    void Start(){
        sceneNumber = SceneManager.GetActiveScene().buildIndex;
    }
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.tag == "Player"){
            aSrc.Play();
            Destroy(bgAudio);
            SceneManager.LoadScene(1);
        }
    }
}
