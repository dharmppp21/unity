using UnityEngine;

public class audiomanager : MonoBehaviour
{
    [Header("-------Audio Source-------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("-------Audio Clip---------")]
    public AudioClip background;
    public AudioClip death;
    public AudioClip eatfood;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
