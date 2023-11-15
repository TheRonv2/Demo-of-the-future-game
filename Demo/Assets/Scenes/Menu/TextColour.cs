using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextColour : MonoBehaviour
{
    public Text textUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GetComponent<Text>().color == Color.black)
            {
                GetComponent<Text>().color = Color.white;
            }
            else
            {
                GetComponent<Text>().color = Color.black;
            }
        }
    }
}
