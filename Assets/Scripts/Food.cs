using UnityEngine;

public class Food : MonoBehaviour
{
    public int HPFood = 10 ;
    public float Delay;
    public AudioClips AudioClips;
    private void Start()
    {
        HPFood = Random.Range(1, HPFood + 1);
        AudioClips = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioClips>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioClips.FoodSound();
            for (int i = 0; i < HPFood; i++)
            {
                other.GetComponent<Player>().AddBone();
            }
            Destroy(gameObject);
        }
    }
}
