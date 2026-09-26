using UnityEngine;

public class PlayAudioOnInteraction : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        // Get the AudioSource component attached to this object
        audioSource = GetComponent<AudioSource>();

        // Ensure audio clip is assigned to the AudioSource
        if (audioSource == null || audioSource.clip == null)
        {
            Debug.LogError("AudioSource or AudioClip is not assigned.");
        }
    }

    void Update()
    {
        // Example: Play audio when the user presses a key (e.g., "Space" key)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Check if the audio source is not null and the clip is assigned
            if (audioSource != null && audioSource.clip != null)
            {
                // Check if the audio is not already playing
                if (!audioSource.isPlaying)
                {
                    // Play the audio clip
                    audioSource.Play();
                }
            }
            else
            {
                Debug.LogWarning("AudioSource or AudioClip is missing.");
            }
        }
    }
}
