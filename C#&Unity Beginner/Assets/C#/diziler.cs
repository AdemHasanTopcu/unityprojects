using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diziler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /* int[] sayilar = new int[] { 1, 2, 3, 60 };
         Debug.Log(sayilar[3]); */
        string[][] arabalar = new string[3][];
        arabalar[0] = new string[] { "bmw", "audi", "mercedes" };
        arabalar[1] = new string[] { "150hp", "200hp", "170hp" };
        arabalar[2] = new string[] { "200k", "500k", "300k" };
        Debug.Log(arabalar[0][2]);
        Debug.Log(arabalar[1][0]);
        Debug.Log(arabalar[2][0]);
            }
}
