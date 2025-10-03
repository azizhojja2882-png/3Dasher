using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forwardSpeed = 8f;
    public float laneDistance = 2f;
    public float jumpForce = 6f;
    public float gravity = -20f;

    int currentLane = 1;
    Vector3 targetPosition;
    CharacterController controller;
    float verticalVelocity = 0f;

    void Awake(){ controller = GetComponent<CharacterController>(); }
    void Start(){ UpdateTargetPosition(); }

    void Update(){
        Vector3 move = Vector3.forward * forwardSpeed;
        float deltaX = (targetPosition.x - transform.position.x) * 10f;
        move.x = deltaX;

        if(controller.isGrounded){
            if(verticalVelocity < 0) verticalVelocity = -1f;
        }
        verticalVelocity += gravity * Time.deltaTime;
        move.y = verticalVelocity;

        controller.Move(move * Time.deltaTime);
    }

    void UpdateTargetPosition(){
        float x = (currentLane - 1) * laneDistance;
        targetPosition = new Vector3(x, transform.position.y, transform.position.z);
    }

    public void MoveLeft(){ if(currentLane > 0){ currentLane--; UpdateTargetPosition(); }}
    public void MoveRight(){ if(currentLane < 2){ currentLane++; UpdateTargetPosition(); }}
    public void Jump(){ if(controller.isGrounded){ verticalVelocity = jumpForce; }}

    public void Die(){
        GameManager.Instance.OnPlayerDead();
    }
}
