using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement pm;
    public GrapplingGun gp;
    public ParticleSystem ps;
    public LifeSystem ls;
    public float bounceForce;

    void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.tag == "Lava"){
            ps.Play();
            SoundManager.PlaySound("DeathSound");
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
            ls.TakeDamage();
            transform.position = pm.checkPointPos;
            gp.grappleRope.enabled = false;
            gp.m_springJoint2D.enabled = false;
        }
        else if (col.gameObject.tag == "Bouncer"){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,bounceForce),ForceMode2D.Impulse);
            SoundManager.PlaySound("BounceSound");
        }
    }
}
