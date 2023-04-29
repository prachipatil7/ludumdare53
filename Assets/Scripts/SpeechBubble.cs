using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpeechBubble : MonoBehaviour
{
    public TMP_Text text;
    public SpriteRenderer sprite;

    private void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("collision!");
        WordDisplay display = collision.gameObject.GetComponent<WordDisplay>();
        if (display.GetTyped() != "") 
        {
            string newWord = display.GetTyped() + " ";
            text.SetText(text.text+newWord);
        }
        display.RemoveWord();
    }

}
