using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource enemyAudio;

    private void Start()
    {
        enemyAudio = GetComponent<AudioSource>();
    }
    public void playEnemyAudio()
    {
        enemyAudio.Play();
    }
}
