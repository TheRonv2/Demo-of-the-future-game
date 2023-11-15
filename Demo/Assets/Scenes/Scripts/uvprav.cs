using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uvprav : MonoBehaviour
{
    GameObject player;
    public Animator anim;
    public float movementSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float direction = player.transform.position.x - transform.position.x;

        if ((Mathf.Abs(direction) < 1) && (Input.GetKeyDown(KeyCode.D)))
        {
            MoveObjectTo(player.transform, new Vector3(player.transform.position.x + 7, player.transform.position.y, player.transform.position.z), movementSpeed);
            anim.SetBool("uvpravo", true);
        }
        else
        {
            anim.SetBool("uvpravo", false);
        }
    }

    private void MoveObjectTo(Transform objectToMove, Vector3 targetPosition, float moveSpeed)
    {
        StopCoroutine(MoveObject(objectToMove, targetPosition, moveSpeed));
        StartCoroutine(MoveObject(objectToMove, targetPosition, moveSpeed));
    }

    public static IEnumerator MoveObject(Transform objectToMove, Vector3 targetPosition, float moveSpeed)
    {
        float currentProgress = 0;
        Vector3 cashedObjectPosition = objectToMove.transform.position;

        while (currentProgress <= 1)
        {
            currentProgress += moveSpeed * Time.deltaTime;

            objectToMove.position = Vector3.Lerp(cashedObjectPosition, targetPosition, currentProgress);

            yield return null;
        }
    }
}