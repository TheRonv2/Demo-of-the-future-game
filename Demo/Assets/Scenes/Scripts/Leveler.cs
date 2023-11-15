using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Leveler : MonoBehaviour
{
    public int levelToLoad;
    public Vector3 position;
    public VectorValue playerStorage;

    IEnumerator Waiting()
    {
        FadeComplete();
        yield return new WaitForSeconds(1f);
    }

    public void FadeComplete()
    {
        playerStorage.initialValue = position;
        SceneManager.LoadScene(levelToLoad);
    }
}
