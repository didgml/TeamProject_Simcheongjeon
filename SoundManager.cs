using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource btnSource;
    public AudioSource musicSource;

    public void SetMusicVolume(float volume)
    {
        if (musicSource != null)
            musicSource.volume = volume;
    }

    public void SetButtonVolume(float volume)
    {
        if (btnSource != null)
            btnSource.volume = volume;
    }

    public void OnSfx()
    {
        if (btnSource != null)
            btnSource.Play();
    }
}
