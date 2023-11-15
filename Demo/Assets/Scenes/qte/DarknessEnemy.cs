using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarknessEnemy : MonoBehaviour
{
    public int speed;
    public RunGamer run;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (run.rn == true)
        {
            speed = 15;
        }
        else
        {
            speed = 10;
        }
    }
}
