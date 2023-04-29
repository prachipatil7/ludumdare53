using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordDisplaySpawner : MonoBehaviour
{
    public GameObject wordPrefab;
    public Transform wordCanvas;

    public WordDisplay SpawnWordDisplay()
    {
        Vector3 randomPos = new Vector3(Random.Range(-2.5f, 2.5f), 7f);
        GameObject wordObj = Instantiate(wordPrefab, randomPos, Quaternion.identity, wordCanvas);
        WordDisplay display = wordObj.GetComponent<WordDisplay>();
        return display;
    }

}
