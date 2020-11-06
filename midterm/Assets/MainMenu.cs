using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(mainMenu());
    }

    IEnumerator mainMenu()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Main Menu");
    }
}
