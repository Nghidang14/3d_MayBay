using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    int currentSceneIndex;
    public void ReloadLevel()
    {
        StartCoroutine(ReLoadLevelRoutine());
    }
    IEnumerator ReLoadLevelRoutine()
    {
        yield return new WaitForSeconds(1f);
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
