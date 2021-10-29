using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foreachtry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] urunler = { "elma", "armut", "kivi" };
        foreach (var item in urunler)
        {
            Debug.Log(item);
        }
    }

}
