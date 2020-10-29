using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiftCollision : MonoBehaviour
{
    public Text levelCompletedText;

    private void Start()
    {
        levelCompletedText.enabled = false;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.gameObject.name == "Player")
        {
            levelCompletedText.enabled = true;
        }
    }
}
