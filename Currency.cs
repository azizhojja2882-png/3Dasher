using UnityEngine;

public class Currency : MonoBehaviour{
    public static Currency Instance;
    public int coins = 0;
    void Awake(){ if(Instance==null) Instance=this; else Destroy(gameObject); }
    public void AddCoins(int v){ coins += v; UIManager.Instance.UpdateCoinText(coins); }
}
