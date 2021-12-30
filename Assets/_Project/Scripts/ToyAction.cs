using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyAction : MonoBehaviour
{
    AudioSource audioData;

    public void Ring()
    {
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
    }
}
