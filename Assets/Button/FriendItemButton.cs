using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FriendItemButton : MonoBehaviour
{
    [SerializeField]
    private GameObject Item;
    [SerializeField]
    private Button Invite;
    [SerializeField]
    private Button Message;
    [SerializeField]
    private Button Delete;

    [SerializeField]
    private GameObject EklenenPaneli;

    private RectTransform ItemTransform;
    private bool changeItem;

    private bool activeFriend;
    /*
     * Çıkarma işlemi için, Message buttonunu kullandım.
     * İşlemi şu şekilde düşündüm:
       Arkadaş listesinden tamamen silmek yerine aktifliğini kaybedecek. 
     */

    void Start()
    {
        activeFriend = true;
        ItemTransform = (RectTransform)Item.transform;
        changeItem = false;
        Invite.gameObject.SetActive(false);
        Message.gameObject.SetActive(false);
        Delete.gameObject.SetActive(false);
    }

    
    void Update()
    {
        
    }

    public void onClickButton() 
    {
        if (changeItem == false)
        {
            Invite.gameObject.SetActive(true);
            Message.gameObject.SetActive(true);
            Delete.gameObject.SetActive(true);
            Item.GetComponent<Image>().enabled = true;
            ItemTransform.sizeDelta = new Vector2(ItemTransform.rect.width, ItemTransform.rect.height * 3);
            changeItem = true;
        }
        else 
        {
            Invite.gameObject.SetActive(false);
            Message.gameObject.SetActive(false);
            Delete.gameObject.SetActive(false);
            Item.GetComponent<Image>().enabled = false;
            ItemTransform.sizeDelta = new Vector2(ItemTransform.rect.width, ItemTransform.rect.height / 3);
            changeItem = false;
        }
    }

    public void onClickInvite() 
    {
        var addItem = Instantiate(Item) as GameObject;
        addItem.GetComponent<Image>().enabled = false;
        RectTransform addItemTransform = (RectTransform)addItem.transform;
        addItemTransform.sizeDelta = new Vector2(addItemTransform.rect.width, addItemTransform.rect.height / 3);
        addItem.transform.SetParent(EklenenPaneli.transform, false);
    }

    public void onClickMessage() 
    {
        if (activeFriend == true)
        {
            Item.SetActive(false);
        }
    }

    public void onClickDelete() 
    {
        Destroy(Item);
    }
}
