using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurbyTalks : MonoBehaviour
{
    [SerializeField] private AudioClip clip;
    private IEnumerator coroutine;

    public void FurbyTalk()
    {
        AudioSource audioSource = FindObjectOfType<AudioSource>();
        coroutine = talking(clip.length);
        audioSource.clip = clip;
        audioSource.Play();
        StartCoroutine(coroutine);
    }

    IEnumerator talking(float seconds)
    {
        ControlArduino.sendTrue();
        yield return new WaitForSeconds(seconds);
        ControlArduino.sendFalse();
    }
}
