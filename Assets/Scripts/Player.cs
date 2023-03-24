using UnityEngine;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    public List<GameObject> BoneSnake = new List<GameObject>();
    public float Zoffset;
    private int hpPlayer = 1;
    public GameObject BonePrefab;
    public float MoveSpeed;
    private float _moveSpeed;
    public TextMesh Text;
    public Game Game;
    public AudioClips AudioClips;

    private void Start()
    {
        BoneSnake[0] = gameObject;
        _moveSpeed = MoveSpeed;
    }
    public void AddBone()
    {
        Vector3 newBonePosition = BoneSnake[BoneSnake.Count - 1].transform.position;
        newBonePosition.z -= Zoffset;
        hpPlayer++;
        BoneSnake.Add(GameObject.Instantiate(BonePrefab, newBonePosition, Quaternion.identity) as GameObject);
    }
    public void DestroyBone()
    {
        hpPlayer--;
        if (hpPlayer <= 0)
        {
            Die();
        }
        else
        {
            AudioClips.DestroyBoneSound();
            Destroy(BoneSnake[BoneSnake.Count - 1]);
            BoneSnake.RemoveAt(BoneSnake.Count - 1);
        }
    }
    void Update()
    {
        if (hpPlayer <= 0)
        {
            MoveSpeed = 0;
        }
        else
        {
            Vector3 motion = new Vector3(0, 0, MoveSpeed);
            transform.position += motion * Time.deltaTime;

            Text.text = BoneSnake.Count.ToString();
        }
        
    }
    public void OffMoveSpeed()
    {
        MoveSpeed = 0;
    }
    public void ReturnMoveSpeed()
    {
        MoveSpeed = _moveSpeed;
    }
    public void Die()
    {
        Game.OnPlayerDied();
    }
    public void ReachFinish()
    {
        Game.OnPlayerReachedFinish();
        MoveSpeed = 0;
    }
}
