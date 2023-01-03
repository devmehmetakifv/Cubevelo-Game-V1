using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyTimeDataManager : MonoBehaviour
{
    public static DontDestroyTimeDataManager instance;
    // Start is called before the first frame update
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
