using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WhiteXXX : MonoBehaviour
{
    public bool ok = true;
    public WhiteXXXX kk;
    public int levelToLoad;
    public Vector3 position;
    public VectorValue playerStorage;


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ok = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ok = false;
        }
    }

    public void onFadeComplete()
    {
        playerStorage.initialValue = position;
        SceneManager.LoadScene(levelToLoad);
    }

    void Update()
    {
        if ((kk.intens >= 9f) && (ok == false))
        {
            onFadeComplete();
        }
    }
}