using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPosUpdate : MonoBehaviour
{
    public Transform target;
    public float offset_x;
    // Start is called before the first frame update
    void FixedUpdate()
    {
        PosUpdate();
    }
    void PosUpdate(){
        transform.position = new Vector3(target.transform.position.x + offset_x,target.transform.position.y,target.transform.position.z);
    }
}
