using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Security.Cryptography;
using UnityEngine.SceneManagement;

public class Alot : MonoBehaviour
{
    public int levelToLoad;
    public Vector3 position;
    public VectorValue playerStorage;

    void Start()
    {
        StartCoroutine("Timer");
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(60);
        onFadeComplete();
    }


    public void onFadeComplete()
    {
        playerStorage.initialValue = position;
        SceneManager.LoadScene(levelToLoad);
    }
}