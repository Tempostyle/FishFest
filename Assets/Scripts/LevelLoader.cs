using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            LoadNextLevel();
        }
    }

    public void LoadNextLevel() 
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        }
        else 
        {
            StartCoroutine(LoadCurrentLevel());
        }
    }

    IEnumerator LoadLevel(int levelIndex) 
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(.50f);
        SceneManager.LoadScene(levelIndex);
    }
    IEnumerator LoadCurrentLevel() 
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(.50f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
