using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MeowLoop : MonoBehaviour
{
    AudioSource audioData;
    [SerializeField, Range(3f, 10f)] private float frequency = 5f;

    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();

        StartCoroutine(Meow());
    }

    private IEnumerator Meow()
    {
        while (true)
        {
            audioData.Play(0);

            //Pausa la coroutina x segundos y después vuelve a ejecutarla
            yield return new WaitForSeconds(frequency);
        }
    }

}