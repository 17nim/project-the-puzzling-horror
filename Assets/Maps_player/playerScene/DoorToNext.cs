using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DoorToNext : MonoBehaviour
{
    public GameObject dialogPanel;
    public GameObject conButton;
    public Text dialogText;
    public string[] dialog;
    private int index;
    public float wordSpeed;
    public string nextScene;
    public bool playerClose;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerClose && Input.GetKeyDown(KeyCode.Space))
        {
            if (dialogPanel.activeInHierarchy)
            {
                dialogText.text = "";
                zeroText();
            }
            else
            {
                dialogPanel.SetActive(true);
                StartCoroutine(Typing());
            }
        }
        if (dialogText.text == dialog[index])
        {
            conButton.SetActive(true);
        }
        else
        {
            conButton.SetActive(false);
        }
    }
    public void NextLine()
    {
        conButton.SetActive(false);
        if (index < dialog.Length - 1)
        {
            index++;
            dialogText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            zeroText(); 
            SceneManager.LoadScene(nextScene);


        }
    }
    public void zeroText()
    {
        dialogText.text = "";
        index = 0;
        dialogPanel.SetActive(false);
    }
    IEnumerator Typing()
    {
        foreach (char letter in dialog[index].ToCharArray())
        {
            dialogText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerClose = true;
            zeroText();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerClose = false;
            zeroText();
        }
    }
}
