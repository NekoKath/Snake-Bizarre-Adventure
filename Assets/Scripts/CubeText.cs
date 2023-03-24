using UnityEngine;

public class CubeText : MonoBehaviour
{
    public Cube Cube;
    public TextMesh Text;

    private void Update()
    {
        Text.text = Cube.HPCube.ToString();
    }
}
