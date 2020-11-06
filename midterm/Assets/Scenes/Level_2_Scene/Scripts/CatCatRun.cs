using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class CatCatRun : MonoBehaviour
{
    private AudioSource source;
    public Text rainbowPowerText;
    public Tilemap tilemap;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            source.Play();
            GetComponent<Animator>().enabled = true;
            rainbowPowerText.GetComponent<Text>().enabled = true;
            rainbowPowerText.GetComponent<Animator>().enabled = true;
            tilemap.GetComponent<TilemapCollider2D>().isTrigger = true;
            tilemap.GetComponent<Animator>().enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            GetComponent<Animator>().enabled = false;
        }
    }
}
