using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public bool IsPlaying = false;
    void Awake(){ if(Instance==null) Instance=this; else Destroy(gameObject); }
    public void StartRun(){ IsPlaying = true; }
    public void OnPlayerDead(){ IsPlaying = false; UIManager.Instance.ShowGameOver(); }
}
