using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using dusmanyonetimi;
using dusmanyonetimi2;

public class namespaceolusturma : MonoBehaviour
{
    dusman dusman = new dusman();
    dusman2 dusman2 = new dusman2();
    void Start()
    {
        dusman.saglik(10);
        dusman2.saglik("deneme");
    }
}
