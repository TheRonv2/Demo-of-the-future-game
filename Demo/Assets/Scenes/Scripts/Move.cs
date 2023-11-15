using UnityEngine;
using System.Collections;
public class Move : MonoBehaviour
{
    public GameObject player;
    public int speedRotation = 3;
    public int speed = 5;
    public int jumpSpeed = 50;

    void Start()
    {
        player = (GameObject)this.gameObject;
    }
    void Update()
    {
        {
            player.transform.position += player.transform.right * speed * Time.deltaTime;
        }
    }
}
