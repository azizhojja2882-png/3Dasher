using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour{
    public static UIManager Instance;
    public Text coinText;
    public GameObject gameOverPanel;

    void Awake(){ if(Instance==null) Instance=this; else Destroy(gameObject); }
    public void UpdateCoinText(int c){ if(coinText) coinText.text = c.ToString(); }
    public void ShowGameOver(){ if(gameOverPanel) gameOverPanel.SetActive(true); }
    public void StartLevel(string sceneName){ SceneManager.LoadScene(sceneName); }
    public void Quit(){ Application.Quit(); }
    public void ShowMessage(string s){ Debug.Log(s); }
}
