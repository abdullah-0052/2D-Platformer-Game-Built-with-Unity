using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance { get; private set; }
    private AudioSource soundsource;
    private AudioSource musicsource;

    private void Awake()
    {
        // Eðer GameObject bir parent altýndaysa ayýr
        transform.parent = null;

        soundsource = GetComponent<AudioSource>();
        musicsource = transform.GetChild(0).GetComponent<AudioSource>();

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        ChangeMusicVolume(0);
        ChangeSoundVolume(0);
    }
    public void PlaySound(AudioClip _sound) => soundsource.PlayOneShot(_sound);

    public void ChangeSoundVolume(float _change)
    {
        ChangeSourceVolume(1, "soundVolme", _change, soundsource);
    }
    public void ChangeMusicVolume(float _change)
    {
        ChangeSourceVolume(0.3f, "musicVolume", _change, musicsource);

    }

    private void ChangeSourceVolume(float baseVolume, string volumeNmae, float change, AudioSource source)
    {
        float currentVolume = PlayerPrefs.GetFloat(volumeNmae ,1);
        currentVolume += change;

        if (currentVolume > 1)
            currentVolume = 0;
        else if (currentVolume < 0)
            currentVolume = 1;

        float finalVolume = currentVolume * baseVolume;
        source.volume = finalVolume;

        PlayerPrefs.SetFloat(volumeNmae, currentVolume);
    }
}
