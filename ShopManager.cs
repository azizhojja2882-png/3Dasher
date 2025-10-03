using UnityEngine;

public class ShopManager : MonoBehaviour{
    public void BuySkin(SkinData skin){
        if(Currency.Instance.coins >= skin.price){ Currency.Instance.coins -= skin.price; SkinManager.Instance.EquipSkin(skin.id); }
        else { UIManager.Instance.ShowMessage("Not enough coins"); }
    }
}
