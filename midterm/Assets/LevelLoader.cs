using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    private string sceneName;
    private AudioSource source;
    private Scene currentScene;

    void Start()
    {
        source = GetComponent<AudioSource>();
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }

    void Update()
    {
        switch (sceneName)
        {
            case "Main Menu":
                if (Input.anyKeyDown)
                {
                    source.Play();
                    LoadNextLevel();
                }
                break;

            default:

                break;
        }
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
}
