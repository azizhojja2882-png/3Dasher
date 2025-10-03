using UnityEngine;
public class Coin : MonoBehaviour
{
    public int value = 1;
    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            Currency.Instance.AddCoins(value);
            Destroy(gameObject);
        }
    }
}
