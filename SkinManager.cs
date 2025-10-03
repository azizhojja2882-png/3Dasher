using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class SkinData{ public string id; public Sprite preview; public int price; public Texture2D texture; }

public class SkinManager : MonoBehaviour{
    public static SkinManager Instance;
    public List<SkinData> skins;
    public string equippedSkinId;

    void Awake(){ if(Instance==null) Instance=this; else Destroy(gameObject); }

    public void EquipSkin(string id){ equippedSkinId = id; ApplySkin(); }
    void ApplySkin(){
        var player = FindObjectOfType<PlayerController>();
        if(player==null) return;
        var rend = player.GetComponentInChildren<Renderer>();
        var s = skins.Find(x=>x.id==equippedSkinId);
        if(s!=null && s.texture!=null){ rend.material.mainTexture = s.texture; }
    }

    public void SetCustomSkin(Texture2D tex){
        var custom = new SkinData(){ id = "custom", texture = tex };
        var idx = skins.FindIndex(x=>x.id=="custom");
        if(idx>=0) skins[idx]=custom; else skins.Add(custom);
        EquipSkin("custom");
    }
}
