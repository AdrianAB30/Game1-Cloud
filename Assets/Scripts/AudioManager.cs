using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource musica;
    public void StopMusic()
    {
        musica.Stop();
    }
}
