using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSupplier : MonoBehaviour
{
    private static string[] wordList = {"cortina", "starvation", "ministries", "regions", "stillwater", "coed", "pcga", "cubase", "ichi", "ample", "soprano", "corgi", "creatures", "thrusting", "haynes", "grumman", "stuart", "nou", "telex", "dorsey", "magicyellow", "macabre", "mig", "lst", "transgression", "keystrokes", "confess", "slaughtered", "preprocessing", "coolant"};
    

    private static string sentence = "I promise to fight for the interests and well-being of all citizens, to create jobs, improve infrastructure, and make our community a better place to live for generations to come."

    public static string GetWord() 
    {
        int index = Random.Range(0, wordList.Length);
        string randomWord = wordList[index];
        return randomWord;
    }
}
