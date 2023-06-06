using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerGetItem : MonoBehaviour
{
    public GameObject Content;
    public Image[] imageComponent;

    private GameObject slot;
    private Color alphaColor;
    private void Start()
    {
        alphaColor = new Color32(255, 255, 255, 255);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (other.CompareTag("Item"))
            {
                Sprite itemImage = other.GetComponent<SpriteRenderer>().sprite;
                Destroy(other.gameObject);

                for (int i = 0; i < Content.transform.childCount; i++)
                {
                    slot = Content.transform.GetChild(i).gameObject;
                    imageComponent = slot.GetComponentsInChildren<Image>();

                    if (imageComponent[1].sprite == null)
                    {
                        imageComponent[1].sprite = itemImage;
                        imageComponent[1].color = alphaColor;
                        ClearList();
                        break;
                    }

                }
            }
        }
    }
    private void ClearList()
    {
        for (int j = 0; j < 2; j++)
        {
            imageComponent[j] = null;
        }
    }

}

