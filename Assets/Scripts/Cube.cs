using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Cube : MonoBehaviour
{
    public int Damage;
    public List<Material> CubeMaterials = new List<Material>();
    public Renderer CubeMaterial;
    public float Delay;
    public int HPCube;
    private Player player;
    private bool _triggerOn = false;

    public void Start()
    {
        Damage = Random.Range(1, Damage + 1);
        CubeMaterial = GetComponent<Renderer>();
        if (Damage <= 5)
        {
            CubeMaterial.sharedMaterial = CubeMaterials[0];
        }
        if (Damage <= 10 & Damage > 5)
        {
            CubeMaterial.sharedMaterial = CubeMaterials[1];
        }
        if (Damage <= 15 & Damage > 10)
        {
            CubeMaterial.sharedMaterial = CubeMaterials[2];
        }
        if (Damage <= 20 & Damage > 15)
        {
            CubeMaterial.sharedMaterial = CubeMaterials[3];
        }
        if (Damage <= 25 & Damage > 20)
        {
            CubeMaterial.sharedMaterial = CubeMaterials[4];
        }
        if (Damage <= 30 & Damage > 25)
        {
            CubeMaterial.sharedMaterial = CubeMaterials[5];
        }
        HPCube = Damage;
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player = other.GetComponent<Player>();
            player.OffMoveSpeed();
            _triggerOn = true;
            do
            {
                player.DestroyBone();
                yield return new WaitForSeconds(Delay);
                HPCube--;
                if (HPCube <= 0)
                {
                    player.AddBone();
                    player.ReturnMoveSpeed();
                    Destroy(gameObject);
                }
            }
            while (_triggerOn == true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        _triggerOn = false;
        player.ReturnMoveSpeed();
    }
}
