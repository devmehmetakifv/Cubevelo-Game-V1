using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public SpriteRenderer chestSpriteRenderer;
    public Sprite heartSprite;
    public LifeSystem ls;
    void Start(){
        gameObject.SetActive(true);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
       {
            SoundManager.PlaySound("OpenChestSound");
            chestSpriteRenderer.sprite = heartSprite;
        }
    }
    void OnTriggerExit2D(Collider2D col){
        if (col.gameObject.CompareTag("Player")){
            gameObject.SetActive(false);
            ls.AddLife();
            SoundManager.PlaySound("CollectCoinSound");
            Debug.Log("Heart collected!");
        }
    }
}
