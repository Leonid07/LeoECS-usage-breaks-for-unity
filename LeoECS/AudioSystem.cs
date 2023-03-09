using Unity.Entities;
using UnityEngine.Audio;

public class AudioSystem : SystemBase
{
    private AudioSource _audioSource;

    protected override void OnCreate()
    {
        // Create an audio source object
        var audioSourceObject = new GameObject("Audio Source");
        _audioSource = audioSourceObject.AddComponent<AudioSource>();
    }

    protected override void OnUpdate()
    {
        Entities.ForEach((Entity entity, in AudioSource audioSource, in AudioClip audioClip) =>
        {
            // Set the audio clip and other properties of the audio source
            _audioSource.clip = audioClip;
            _audioSource.volume = audioSource.volume;
            _audioSource.pitch = audioSource.pitch;
            _audioSource.loop = audioSource.loop;

            // Play the audio clip
            _audioSource.Play();
        }).Schedule();
    }

    protected override void OnDestroy()
    {
        // Destroy the audio source object when the system is destroyed
        UnityEngine.Object.Destroy(_audioSource.gameObject);
    }
}