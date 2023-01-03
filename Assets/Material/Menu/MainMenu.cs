using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject bgAudio;
    
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        Destroy(bgAudio);
    }


    public void Tutorial()
    {
        SceneManager.LoadScene(7);//Tutorial Bölüm ismi gir
        Destroy(bgAudio);
    }
    public void About(){
        SceneManager.LoadScene(8);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QUIT");
    }
}
