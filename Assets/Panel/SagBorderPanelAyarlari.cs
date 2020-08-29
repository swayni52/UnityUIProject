using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SagBorderPanelAyarlari : MonoBehaviour
{
    [SerializeField]
    private GameObject[] panels;
    [SerializeField]
    private GameObject[] playerPanelItems;
    [SerializeField]
    private GameObject[] rankPanelItems;
    [SerializeField]
    private GameObject[] friendPanelItems;

    private RectTransform playerLvlExt;

    float maxlvlexp = 150.0f;
    float lvlExp = 40.0f;
    void Start()
    {
        playerLvlExt = (RectTransform)playerPanelItems[5].transform;
        FillLevelBar(maxlvlexp, lvlExp);
    }

    
    void Update()
    {
        
    }

    private void FillLevelBar(float lvlMaxExp, float lvlExp) 
    {
        playerLvlExt.sizeDelta = new Vector2(playerLvlExt.rect.width * (lvlExp / lvlMaxExp), playerLvlExt.rect.height);
    }
}
