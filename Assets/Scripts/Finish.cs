using UnityEngine;

public class Finish : MonoBehaviour
{
    public ParticleSystem ParticleSystemLeft;
    public ParticleSystem ParticleSystemRight;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayParycleSystem();
            other.GetComponent<Player>().ReachFinish();
        }
    }
    public void PlayParycleSystem()
    {
        ParticleSystemLeft.Play();
        ParticleSystemRight.Play();
    }
}
