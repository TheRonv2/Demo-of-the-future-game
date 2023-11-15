using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangerLevel : MonoBehaviour
{
    public int levelToLoad;
    public Vector3 position;
    public VectorValue playerStorage;
    GameObject player;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    private void Update()
    {
        float direction = player.transform.position.x - transform.position.x;
        if ((Input.GetKeyDown(KeyCode.Q)) && (Mathf.Abs(direction) < 2))
        {
            onFadeComplete();
        }
    }

    public void onFadeComplete()
    {
        playerStorage.initialValue = position;
        SceneManager.LoadScene(levelToLoad);
    }
}