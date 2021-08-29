using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i;
    public Renderer rend;
    private GameObject[] gameObjects;
    private int a;
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        a = Random.Range(200, 251);
        gameObjects = GameObject.FindGameObjectsWithTag("Red");
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        PrintAndHide.print(gameObject.name + ":" + i);
        if (i == 100)
            foreach (GameObject gameObject in gameObjects)
                gameObject.SetActive(false);
        if (i == a) GameObject.FindGameObjectWithTag("Blue").GetComponent<Renderer>().enabled = false;
    }
}
