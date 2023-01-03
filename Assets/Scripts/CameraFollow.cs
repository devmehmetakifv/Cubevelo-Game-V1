using UnityEngine;
using System.Collections;
 
public class CameraFollow : MonoBehaviour {
     
    public float dampTime = 0.15f;
    private Vector3 velocity = Vector3.zero;
    public Transform target;
    public float offset;
 
    // Update is called once per frame
    void Update () 
    {
        if (target)
        {
            Vector3 point = GetComponent<Camera>().WorldToViewportPoint(target.position);
            Vector3 delta = target.position - GetComponent<Camera>().ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
            Vector3 destination = new Vector3(transform.position.x+offset,transform.position.y+offset,transform.position.z) + delta;
            transform.position = Vector3.SmoothDamp(new Vector3(transform.position.x+offset,transform.position.y+offset,transform.position.z), destination, ref velocity, dampTime);
        }
     
    }
}
