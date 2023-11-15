using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2DCheck : MonoBehaviour
{
    public int levelToLoad;
    GameObject check;
    GameObject player;
    public Vector3 position;
    public VectorValue playerStorage;

    private void Start()
    {
        check = GameObject.FindWithTag("Check");
        player = GameObject.FindWithTag("Player");
    }

    private void Update()
    {
        float direction = check.transform.position.y - transform.position.y;
        float direction1 = player.transform.position.x - transform.position.x;
        if ((Input.GetKey(KeyCode.Q)) && (Mathf.Abs(direction) < 1) && (Mathf.Abs(direction1) < 1))
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