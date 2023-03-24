using UnityEngine;

public class TailMovement : MonoBehaviour
{
    public float MoveSpeed;
    public Vector3 boneTarget;
    public GameObject boneTargetObject;
    public Player Player;

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        boneTargetObject = Player.BoneSnake[Player.BoneSnake.Count - 1];
    }
    void Update()
    {
        boneTarget = boneTargetObject.transform.position;
        boneTarget.z -= Player.Zoffset;
        transform.LookAt(boneTarget);
        transform.position = Vector3.Lerp(transform.position, boneTarget, MoveSpeed *Time.deltaTime);
    }
}
