using UnityEngine.Audio;
using UnityEngine;

public class EnemyAudio : MonoBehaviour
{

    public AudioSource enemyAudio;
    void Start()
    {
        enemyAudio = GetComponent<AudioSource>();
        enemyAudio.Pause();
    }
    public void playEnemyAudio()
    {
        enemyAudio.Play();
    }
}
