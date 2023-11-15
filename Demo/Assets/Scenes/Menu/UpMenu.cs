using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpMenu : MonoBehaviour
{
    public StartFor kk;
    public Animator anim;
    public Button startButton;
    public Button ContinueButton;
    public Button EndButton;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (kk.gg == false)
        {
            anim.SetTrigger("Upp");
            startButton.interactable = false;
            ContinueButton.interactable = false;
            EndButton.interactable = false;
        }
    }
}
