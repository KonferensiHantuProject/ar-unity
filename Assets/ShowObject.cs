using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowObject : MonoBehaviour
{
    // public GameObject activeGameObject;

    // List of objects
    public GameObject[] targets;

    public void ActiveObject()
    {
        for(int i = 0; i < targets.Length; i++)
        {
            // Code to be repeated.
            if(targets[i].activeSelf != true)
            {
                targets[i].SetActive(true);
            }else
            {
                targets[i].SetActive(false);
            }
        }

    }
}
