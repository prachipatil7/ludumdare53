using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WordDisplay : MonoBehaviour
{
    public TMP_Text text;
    private string typed = string.Empty;
    private string untyped = string.Empty;
    private string typedColor = "<color=\"red\">";
    private string untypedColor = "<color=\"white\">";
    public float fallSpeed=1.5f;

    public void SetWord(string word)
    {
        untyped = word;
        text.SetText(untypedColor+untyped);
    }

    public void ShowTypedLetter(char letter)
    {
        untyped = untyped.Substring(1);
        typed += letter;
        string newText = typedColor+typed+untypedColor+untyped;
        text.SetText(newText);
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
    }

    public string GetTyped()
    {
        return typed;
    }

    private void Update()
    {
        transform.Translate(0f, -fallSpeed*Time.deltaTime, 0f);
    }
}
