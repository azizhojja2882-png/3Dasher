using UnityEngine;
public class Obstacle : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            other.GetComponent<PlayerController>().Die();
        }
    }
}
