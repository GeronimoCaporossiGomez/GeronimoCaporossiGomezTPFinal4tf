using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public GameObject[] objects;
    int currentIndex = -1;
    // Start is called before the first frame update
    void Start()
    {
       Desactivar();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            currentIndex++;
            if (currentIndex >= objects.Length)
            {
                currentIndex = 0;
            }
           Desactivar();
            ActivateByIndex(currentIndex);
        }
    }

    void Desactivar()
    {
        for (int X = 0; X < objects.Length; X++)
        {
            objects[X].SetActive(false);
        }
    }
    void ActivateByIndex(int index)
    {
        objects[index].SetActive(true);
    }
}
