using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public CoinSystem cs;
    void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.tag == "Player"){
            SoundManager.PlaySound("CollectCoinSound");
            cs.AddCoin();
            Destroy(gameObject);
        }
    }
}
