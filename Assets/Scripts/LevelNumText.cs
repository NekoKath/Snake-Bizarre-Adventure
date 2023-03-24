using UnityEngine;
using UnityEngine.UI;

public class LevelNumText : MonoBehaviour
{
    public Text CurrentLevelText;
    public Text NextLevelText;
    public Game Game;

    private void Start()
    {
        CurrentLevelText.text = (Game.LevelIndex + 1).ToString();
        NextLevelText.text = (Game.LevelIndex + 2).ToString();
    }
}
