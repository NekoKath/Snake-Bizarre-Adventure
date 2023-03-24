using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public Control Control;
    private const string LevelIndexKey = "LevelIndex";
    public float SoundDelay;
    public AudioClips AudioClips;


    public int LevelIndex
    {
        get => PlayerPrefs.GetInt(LevelIndexKey, 0);
        private set
        {
            PlayerPrefs.SetInt(LevelIndexKey, value);
            PlayerPrefs.Save();
        }
    }
    public enum State
    {
        Playing,
        Win,
        Loss,
    }

    public void OnPlayerDied()
    {
        if (CurrentState != State.Playing) return;

        CurrentState = State.Loss;
        Control.enabled = false;
        ReloadLevel();
    }
    public void OnPlayerReachedFinish()
    {
        if (CurrentState != State.Playing) return;

        CurrentState = State.Win;
        Control.enabled = false;
        LevelIndex++;
        AudioClips.FinishSound();
        Invoke("PlayerWin", SoundDelay);
    }
    public State CurrentState { get; private set; }

    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayerWin()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    
}
