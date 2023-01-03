using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyMusic : MonoBehaviour
{
    public static DontDestroyMusic instance;
    void Awake(){
        if (instance== null)
            {
                instance=this;
                DontDestroyOnLoad(gameObject);
            }
    
        else 
        {
            Destroy(gameObject);
        }
    }
}
