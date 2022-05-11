using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIdialog : MonoBehaviour
{
    [SerializeField]
    private GameObject Panel;
    [SerializeField]
    private Text refTextDialog;
    [SerializeField]
    private string Message;
    private bool playerInRange = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("activate") && playerInRange)
        {
            TogglePanel();
        }
    }

    private void TogglePanel()
    {
        if (!Panel.activeSelf)
        {
            refTextDialog.text = Message;
            Panel.SetActive(true);
        }
        else
        {
            refTextDialog.text = "";
            Panel.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            playerInRange = false;
            Panel.SetActive(false);
        }
    }
}
