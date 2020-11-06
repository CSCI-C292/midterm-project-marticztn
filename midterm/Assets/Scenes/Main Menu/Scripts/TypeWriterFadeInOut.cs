using System.Collections;
using TMPro;
using UnityEngine;

public class TypeWriterFadeInOut : MonoBehaviour
{
    public float delay = 0.1f;
    public string fullText;
    private bool routineFinished;
    private string currentText = "";
    private Animator fadeInOutAnimator;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowText());
        StartCoroutine(ShowFadeEffect());
    }

    IEnumerator ShowText()
    {
        routineFinished = false;
        for (int i = 0; i < fullText.Length + 1; i++)
        {
            currentText = fullText.Substring(0, i);
            GetComponent<TextMeshProUGUI>().text = currentText;
            yield return new WaitForSeconds(delay);
        }
        routineFinished = true;
    }

    IEnumerator ShowFadeEffect()
    {
        while (!routineFinished)
            yield return new WaitForSeconds(0.1f);

        GetComponent<Animator>().enabled = true;
    }

}
