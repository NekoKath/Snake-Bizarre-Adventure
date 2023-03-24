using UnityEngine;

public class AudioClips : MonoBehaviour
{
    public AudioClip DestroyBone;
    public AudioClip Die;
    public AudioClip Finish;
    public AudioClip Food;

    private AudioSource _audio;

    private void Start()
    {
        _audio = GetComponent<AudioSource>();
    }

    public void DestroyBoneSound()
    {
        _audio.PlayOneShot(DestroyBone);
    }
    public void FinishSound()
    {
        _audio.PlayOneShot(Finish);
    }
    public void FoodSound()
    {
        _audio.PlayOneShot(Food);
    }    
}
