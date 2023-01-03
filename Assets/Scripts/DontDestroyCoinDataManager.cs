using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyCoinDataManager : MonoBehaviour
{
    public static DontDestroyCoinDataManager instance;
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
