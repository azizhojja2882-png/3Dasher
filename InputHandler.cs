using UnityEngine;

public class InputHandler : MonoBehaviour
{
    PlayerController player;
    Vector2 startTouch, endTouch;
    bool isSwiping = false;

    void Start(){ player = FindObjectOfType<PlayerController>(); }

    void Update(){
        if(Input.GetKeyDown(KeyCode.LeftArrow)) player.MoveLeft();
        if(Input.GetKeyDown(KeyCode.RightArrow)) player.MoveRight();
        if(Input.GetKeyDown(KeyCode.Space)) player.Jump();

        if(Input.touchCount == 1){
            Touch t = Input.GetTouch(0);
            if(t.phase == TouchPhase.Began){ startTouch = t.position; isSwiping = true; }
            else if(t.phase == TouchPhase.Ended && isSwiping){ endTouch = t.position; HandleSwipe(); isSwiping = false; }
        }
    }

    void HandleSwipe(){
        Vector2 delta = endTouch - startTouch;
        if(delta.magnitude < 50) return;
        if(Mathf.Abs(delta.x) > Mathf.Abs(delta.y)){
            if(delta.x > 0) player.MoveRight(); else player.MoveLeft();
        } else {
            if(delta.y > 0) player.Jump();
        }
    }
}
