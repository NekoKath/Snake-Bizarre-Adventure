using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Player Player;
    public LevelGenerator Level;
    public Slider Slider;
    private float _startZ;
    private float _finishZ;

    private void Start()
    {
        _startZ = Player.transform.position.z;
        _finishZ = Player.transform.position.z + (20 * Level.LevelLenght - 20);
    }
    private void Update()
    {
        float _currentZ = Player.transform.position.z;
        float t = Mathf.InverseLerp(_startZ, _finishZ, _currentZ);
        Slider.value = t;
    }
}
