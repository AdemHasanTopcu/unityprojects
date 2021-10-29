using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class degiskenler : MonoBehaviour
{
    string metnim = "Merhaba Hasan";
    int yas = 80;
    float kusurat = 3.10f;
    double kusurat2 = 3.2120;
    bool acikmi = false;
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Merhaba");
        Debug.Log(metnim);
        Debug.Log(yas);
        Debug.Log(kusurat);
        Debug.Log(kusurat2);
        Debug.Log(acikmi);
    }
}
