using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "Player"){
            Debug.Log("Next Level / Main Menu");
        }
    }
}
