using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public PlayerMovement pm;
    public Transform player;
    public Transform gameStartingPoint;
    public SpriteRenderer innerCheckpoint;
    public LifeSystem ls;
    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "Player"){
            if (!ls.isDead){
                pm.checkPointPos = new Vector3(player.transform.position.x,player.transform.position.y,player.transform.position.z);
            }
            if (ls.isDead){
                pm.checkPointPos = gameStartingPoint.transform.position;
                player.transform.position = pm.checkPointPos;
                ls.isDead = false;
            }
            if (innerCheckpoint.color != new Color(0,127,0))
            {
                SoundManager.PlaySound("CheckpointSound");
            }
            if (pm.checkPointPos == gameStartingPoint.transform.position){
                innerCheckpoint.color = new Color(0,90,120);
            }
            innerCheckpoint.color = new Color(0,127,0);
        }
    }
}
