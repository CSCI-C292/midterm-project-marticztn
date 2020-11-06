using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodCollision : MonoBehaviour
{
    private int count = 0;
    public GameObject gift;
    List<GameObject> triggered;
    private void Start()
    {
        triggered = new List<GameObject>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject obj = other.gameObject;
        if (obj.transform.parent.gameObject.name == "Nodding")
        {
            if(!triggered.Contains(obj))
            {
                count++;
                triggered.Add(obj);

                Debug.Log("Count: " + count);
            }

            obj.GetComponent<Animator>().enabled = true;
        }
    }

    private void Update()
    {
        if(count == 10)
        {
            gift.SetActive(true);
        }
    }
}
