using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchdersim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int sayi = 2;
        switch (sayi){
            case 1:
                Debug.Log("evet");
                break;

            case 2:
                Debug.Log("hayýr");
                break;

            case 3:
                Debug.Log("biraz");
                break;
            default:
                Debug.Log("yok kayýt");
                break;
        }
    }

}
