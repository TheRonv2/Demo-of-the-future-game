using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class VisText : MonoBehaviour
{
    public Text textUI;
    public bool dd = false;
    public bool past = false;
    public bool cont = false;
    public bool keyPress = false;
    public bool Triiger = false;
    public VisTex vt;
    public GameObject Object;
    public GameObject game;
    public string text;
    public Animator anim;
    public Animator animator;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.CompareTag("Player")) && (dd == false))
        {
            StartCoroutine("showText", text);
            dd = true;
            past = true;
            anim.Play("nooo");
            animator.Play("texten");
            Triiger = true;
        }
    }

    IEnumerator showText(string text)
    {
        int i = 0;
        while ((i <= text.Length) && (cont == false))
        {
            textUI.text = text.Substring(0, i);
            i++;

            yield return new WaitForSeconds(0.05f);
        }
    }

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.H)) && (Triiger == true) && (dd == true))
        {
            keyPress = !keyPress;
            cont = true;
            int i = 0;
            if (keyPress == true)
            {
                while ((i <= text.Length) && (cont == true))
                {
                    textUI.text = text.Substring(0, i);
                    i++;
                }
            }
            else if (keyPress == false)
            {
                anim.Play("this");
                animator.Play("textdis");
            }
        }

        if ((vt.past == true) && (dd == true))
        {
            Destroy(Object);
            Destroy(game);
        }
    }
}