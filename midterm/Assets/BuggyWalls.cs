using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuggyWalls : MonoBehaviour
{
    private int counter = 0;
    private AudioSource audioSource;
    public AudioClip audioClipImpact;
    public AudioClip audioClipOMG;
    public Text textOMG;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        textOMG.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        counter++;
        if (counter == 1)
        {
            audioSource.PlayOneShot(audioClipImpact);
            audioSource.PlayOneShot(audioClipOMG);
            textOMG.enabled = true;
        }
    }
}