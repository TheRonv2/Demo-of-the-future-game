using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Letter2 : MonoBehaviour
{
    GameObject player;
    public int levelToLoad;
    public VectorValue playerStorage;
    public Vector3 position;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Start is called before the first frame update
    private void Update()
    {

        float direction = player.transform.position.x - transform.position.x;
        if ((MoneyText.Coin == 40) || (MoneyText.Coin == 45) || (MoneyText.Coin == 120) || (MoneyText.Coin == 125))
        {
            Destroy(this);
        }
        else if ((Input.GetKeyDown(KeyCode.Q)) && (Mathf.Abs(direction) < 2))
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