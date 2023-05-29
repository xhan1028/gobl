using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class G_CardAnimation : MonoBehaviour
{
    public Image cardImageDisplay;
    public G_CardList cardList;

    private void Awake()
    {
        // Assign the Image component by finding it in the scene or reference it through the inspector.
        //cardImageDisplay = GetComponentInChildren<Image>();
        
        // Find the G_CardList component in the scene.
        cardList = FindObjectOfType<G_CardList>();
    }

    public void OnButtonClick()
    {
        // Call the ResultSelect() method to get a random card.
        cardList.ResultSelcet();

        // Access the returned card and assign its cardImage to the Image component's sprite property.
        Card randomCard = cardList.result[0];
        cardImageDisplay.sprite = randomCard.cardImage;
    }
}