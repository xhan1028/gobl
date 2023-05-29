using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum CardGrade { One = 1, Two =2, Three=3, Four=4, Five=5, Six=6, Devil=7 }

[System.Serializable]
public class Card
{
    public string cardName;
    public Sprite cardImage;
    public CardGrade cardGrade;
    public int percentege;

    public Card(Card card)
    {
        this.cardName = card.cardName;
        this.cardImage = card.cardImage;
        this.cardGrade = card.cardGrade;
        this.percentege = card.percentege;
    }
}
