using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifelsedersim : MonoBehaviour
{
    int sayi1 = 5;
    int sayi2 = 10;
    int sayi3 = 6;
    bool a = false;
    // Start is called before the first frame update
    void Start()
    {
        if (!a)
            Debug.Log("Yanl��");
        else
            Debug.Log("Do�ru");
        if (sayi1 > sayi2 && sayi2>sayi1) { 
        Debug.Log("Evet");
        }
        else if (sayi3 >= sayi1)
        {
            Debug.Log("Yepp");
        }
        else
        {
            Debug.Log("Hay�r");
        }
        
    }
    
}
