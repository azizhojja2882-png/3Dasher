using UnityEngine;

[System.Serializable]
public class LevelTheme
{
    public Material groundMaterial;
    public Material obstacleMaterial;
    public Color ambientLight;
    public Cubemap skybox;
}

public class LevelThemeManager : MonoBehaviour
{
    public LevelTheme[] themes;
    public int levelIndex = 0;

    void Start()
    {
        ApplyTheme(levelIndex);
    }

    public void ApplyTheme(int index)
    {
        if (index < 0 || index >= themes.Length) return;
        RenderSettings.ambientLight = themes[index].ambientLight;
        if (themes[index].skybox != null) RenderSettings.skybox = new Material(Shader.Find("Skybox/Cubemap")) { };
        GameObject ground = GameObject.FindWithTag("Ground");
        if (ground) ground.GetComponent<Renderer>().material = themes[index].groundMaterial;

        foreach (GameObject obs in GameObject.FindGameObjectsWithTag("Obstacle"))
        {
            obs.GetComponent<Renderer>().material = themes[index].obstacleMaterial;
        }
    }
}
