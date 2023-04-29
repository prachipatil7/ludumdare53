using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour
{
    public WordSpawner spawner;

    public float wordDelay = 1.5f;
    private float nextWordTime = 0f;

    private void Update()
    {
        if (Time.time >= nextWordTime) {
            spawner.AddWord();
            nextWordTime = Time.time + wordDelay;
        }
    }


}
