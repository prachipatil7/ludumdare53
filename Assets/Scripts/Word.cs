using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word
{
    public string word;
    private int currLetterIndex;
    WordDisplay display;

    public Word(string newWord, WordDisplay newDisplay)
    {
        word = newWord;
        currLetterIndex = 0;

        display = newDisplay;
        display.SetWord(word);
    }

    public char GetNextLetter()
    {
        return word[currLetterIndex];
    }

    public void TypeLetter(char letter)
    {
        currLetterIndex++;
        display.ShowTypedLetter(letter);
    }

    public bool IsComplete() 
    {
        bool completed = (currLetterIndex >= word.Length);
        return completed;
    }

    public bool IsDestroyed()
    {
        bool destroyed = (display == null);
        return destroyed;

    }
}
