using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class publicmetodlar : MonoBehaviour
{
    private IEnumerator birincicont;
    void Start()
    {
        StartCoroutine(Denemem(4));
    }
    IEnumerator Denemem(float saniyem)
    {
        while(true)
        {
            Debug.Log("1.yazd�rma");
            yield return new WaitForSeconds(saniyem);
            Debug.Log("4 saniye bekledim");
        }
    }
}
