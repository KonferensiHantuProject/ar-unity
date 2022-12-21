using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddNumberScript : MonoBehaviour
{
    // Text Counter
    [SerializeField] Text txtDisplayNumber;

    // Buttons
    public GameObject buttonLeft;
    public GameObject buttonRight;

    // List of objects
    public GameObject[] targets;

    int counter = 0;
    void Start()
    {
        DisplayNumber();
        targets[0].SetActive(true);
    }

    // Menambah dan Menampilkan Angka
    public void IncreaseAndDisplay() 
    {
        IncreaseValueByOne();
        DisplayNumber();
    }

    // Menambah dan Menampilkan Angka
    public void DecreaseAndDisplay() 
    {
        DecreaseValueByOne();
        DisplayNumber();
    }

    // Menambah Value
    void IncreaseValueByOne()
    {
        counter++;
    }

    // Menambah Value
    void DecreaseValueByOne()
    {
        counter--;
    }

    // Menampilkan Angka
    void DisplayNumber()
    {
        txtDisplayNumber.text = counter.ToString();

        // Activating and Deactivating Left Button
        if(int.Parse(txtDisplayNumber.text) == 0)
        {
            buttonLeft.SetActive(false);
        }else
        {
            buttonLeft.SetActive(true);
        }

        // Activating and Deactivating Right Button
        if(int.Parse(txtDisplayNumber.text) == targets.Length - 1)
        {
            buttonRight.SetActive(false);
        }else
        {
            buttonRight.SetActive(true);
        }
    }

}
