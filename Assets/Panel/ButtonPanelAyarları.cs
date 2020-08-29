using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPanelAyarları : MonoBehaviour
{
    [SerializeField]
    private GameObject FriendPanel;
    [SerializeField]
    private GameObject EklenenPanel;
    [SerializeField]
    private GameObject NeoldugunuanlamadımPanel2;
    [SerializeField]
    private GameObject NeoldugunuanlamadımPanel3;


    [SerializeField]
    private Button FriendButton;
    [SerializeField]
    private Button EklenenButton;
    [SerializeField]
    private Button NeoldugunuanlamadımButton2;
    [SerializeField]
    private Button NeoldugunuanlamadımButton3;
    void Start()
    {
        FriendPanel.SetActive(true);
        EklenenPanel.SetActive(false);
        NeoldugunuanlamadımPanel2.SetActive(false);
        NeoldugunuanlamadımPanel3.SetActive(false);

        FriendButton.GetComponent<Button>().enabled = false;

        FriendButton.GetComponent<Image>().color = new Color32(185, 185, 185, 255);
    }

    public void friendPanelButton() 
    {
        FriendPanel.SetActive(true);
        EklenenPanel.SetActive(false);
        NeoldugunuanlamadımPanel2.SetActive(false);
        NeoldugunuanlamadımPanel3.SetActive(false);

        FriendButton.GetComponent<Button>().enabled = false;
        EklenenButton.GetComponent<Button>().enabled = true;
        NeoldugunuanlamadımButton2.GetComponent<Button>().enabled = true;
        NeoldugunuanlamadımButton3.GetComponent<Button>().enabled = true;

        FriendButton.GetComponent<Image>().color = new Color32(185, 185, 185, 255);
        EklenenButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        NeoldugunuanlamadımButton2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        NeoldugunuanlamadımButton3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
    }

    public void neoldugunuanlamadımPanel1Button() 
    {
        FriendPanel.SetActive(false);
        EklenenPanel.SetActive(true);
        NeoldugunuanlamadımPanel2.SetActive(false);
        NeoldugunuanlamadımPanel3.SetActive(false);
        /////
        EklenenButton.GetComponent<Button>().enabled = false;
        FriendButton.GetComponent<Button>().enabled = true;
        NeoldugunuanlamadımButton2.GetComponent<Button>().enabled = true;
        NeoldugunuanlamadımButton3.GetComponent<Button>().enabled = true;
        //////
        FriendButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        EklenenButton.GetComponent<Image>().color = new Color32(185, 185, 185, 255);
        NeoldugunuanlamadımButton2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        NeoldugunuanlamadımButton3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
    }
    public void neoldugunuanlamadımPanel2Button()
    {
        FriendPanel.SetActive(false);
        EklenenPanel.SetActive(false);
        NeoldugunuanlamadımPanel2.SetActive(true);
        NeoldugunuanlamadımPanel3.SetActive(false);

        NeoldugunuanlamadımButton2.GetComponent<Button>().enabled = false;
        EklenenButton.GetComponent<Button>().enabled = true;
        FriendButton.GetComponent<Button>().enabled = true;
        NeoldugunuanlamadımButton3.GetComponent<Button>().enabled = true;

        FriendButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        EklenenButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        NeoldugunuanlamadımButton2.GetComponent<Image>().color = new Color32(185, 185, 185, 255);
        NeoldugunuanlamadımButton3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
    }
    public void neoldugunuanlamadımPanel3Button()
    {
        FriendPanel.SetActive(false);
        EklenenPanel.SetActive(false);
        NeoldugunuanlamadımPanel2.SetActive(false);
        NeoldugunuanlamadımPanel3.SetActive(true);

        NeoldugunuanlamadımButton3.GetComponent<Button>().enabled = false;
        EklenenButton.GetComponent<Button>().enabled = true;
        NeoldugunuanlamadımButton2.GetComponent<Button>().enabled = true;
        FriendButton.GetComponent<Button>().enabled = true;

        FriendButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        EklenenButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        NeoldugunuanlamadımButton2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        NeoldugunuanlamadımButton3.GetComponent<Image>().color = new Color32(185, 185, 185, 255);
    }
}
