using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightqte : MonoBehaviour
{
    public Animator anim;
    GameObject enemy;

    private void Start()
    {
        enemy = GameObject.FindWithTag("Enemy");
    }

    // Start is called before the first frame update
    private void Update()
    {
        float direction = enemy.transform.position.x - transform.position.x;

        if (Mathf.Abs(direction) < 2)
        {
            anim.Play("lightoff");
            StartCoroutine(ExampleCoroutine());
        }
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
