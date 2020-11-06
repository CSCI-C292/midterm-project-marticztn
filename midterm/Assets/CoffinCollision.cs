using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffinCollision : MonoBehaviour
{
    private int count = 0;
    public GameObject gift;
    public GameObject coffinDanceGroup1;
    public GameObject coffinDanceSingle;
    List<GameObject> triggered;

    private void Start()
    {
        triggered = new List<GameObject>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        GameObject obj = other.gameObject;
        if (obj.transform.parent.gameObject.name == "Coffin")
        {
            if (!triggered.Contains(obj))
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
        if (count == 4)
        {
            count = 0;
            StartCoroutine(ShowCoffinGroup());
            coffinDanceSingle.SetActive(true);
            gift.SetActive(true);
        }
    }

    IEnumerator ShowCoffinGroup()
    {
        coffinDanceGroup1.SetActive(true);
        yield return new WaitForSeconds(2);
        coffinDanceGroup1.SetActive(false);
    }
}
