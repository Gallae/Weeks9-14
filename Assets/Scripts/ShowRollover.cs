using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowRollover : MonoBehaviour
{
    public Image image;

    public Sprite highlight;
    public Sprite normal;
    public TextMeshProUGUI reactionText;

    public void MouseIsOverUs()
    {
        image.sprite = highlight;
        reactionText.text = "Bleh! Broccoli!";
    }

    public void MouseNotOverUs()
    {
        image.sprite = normal;
        reactionText.text = "Ooh, a burger!";
    }
}
