using UnityEngine;
public class CameraController : MonoBehaviour{
    public Transform target;
    public bool fixedCamera = false;
    public Vector3 fixedOffset = new Vector3(0,6,-8);
    public Vector3 followOffset = new Vector3(0,4,-6);
    public float followDelay = 0.15f;

    Vector3 vel = Vector3.zero;
    void LateUpdate(){
        if(target==null) return;
        if(fixedCamera){ transform.position = target.position + fixedOffset; transform.LookAt(target); }
        else {
            Vector3 desired = target.position + followOffset;
            transform.position = Vector3.SmoothDamp(transform.position, desired, ref vel, followDelay);
            transform.LookAt(target);
        }
    }
}
