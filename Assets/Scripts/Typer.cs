using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Typer : MonoBehaviour
{
    public WordSpawner wordSpawner;
    void Update()
    {
        foreach (char letter in Input.inputString)
        {
            wordSpawner.TypeLetter(letter);
        }
    }
}
