using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runnnn : MonoBehaviour
{
    public int speed;
    public ObjectHand objectHand;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (objectHand.oh == true)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}