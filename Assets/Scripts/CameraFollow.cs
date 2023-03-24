using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player;
    private Vector3 previosPosition;
    
    void Update()
    {

        if (Player == null)
        {
            transform.position = new Vector3(previosPosition.x, previosPosition.y, previosPosition.z - 15);
        }
        else
        {
            previosPosition = transform.position;
            Vector3 currentPlayerPosition = new Vector3(Player.position.x, Player.position.y, Player.position.z);
            transform.position = new Vector3(0, 10, currentPlayerPosition.z - 15);
        }
    }
}
