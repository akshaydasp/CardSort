using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameManager gameManager;
    public ScoreManager scoreManager;
    public TextMeshProUGUI scoreText;          
    public TextMeshProUGUI bestText;         
    public TextMeshProUGUI comboText;         
    public string saveFile = "save.json";
    void Update()
    {     
       
        if (scoreManager && scoreText) scoreText.text = $"Score: {scoreManager.CurrentScore}";
        if (scoreManager && bestText) bestText.text = $"Best:  {scoreManager.BestScore}";
        if (scoreManager && comboText) comboText.text = $"Combo: {scoreManager.ComboCount}";
    }

    public void Save() { gameManager.SaveGame(saveFile); }
    public void Load() { gameManager.LoadGame(saveFile); }
    public void NewGame()
    {
        gameManager.NewRandomGame();
    }
}
