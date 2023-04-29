using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{
    public List<Word> words;
    public WordDisplaySpawner displaySpawner;
    private bool hasActiveWord;
    private Word activeWord;    

    public void AddWord() 
    {
        Word word = new Word(WordSupplier.GetWord(), displaySpawner.SpawnWordDisplay());
        Debug.Log(word.word);
        words.Add(word);
    }

    public void TypeLetter(char letter) 
    {
        if (hasActiveWord)
        {
            if (activeWord.GetNextLetter()==letter)
            {
                activeWord.TypeLetter(letter);
            }
        }
        else 
        {
            foreach(Word word in words)
            {
                if (word.GetNextLetter()==letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter(letter);
                    break;
                }
            }
        }
        if (hasActiveWord && (activeWord.IsComplete() || activeWord.IsDestroyed() ))
        {
            hasActiveWord = false;
            words.Remove(activeWord);
        }
    }
}
