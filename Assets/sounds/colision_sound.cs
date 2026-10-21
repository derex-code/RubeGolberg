using UnityEngine;

public class SonidoColision : MonoBehaviour
{
    private AudioSource miAudio;

    void Start()
    {
        miAudio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision colision)
    {
        if (colision.relativeVelocity.magnitude > 1f)
        {
            miAudio.Play();
        }
    }
}