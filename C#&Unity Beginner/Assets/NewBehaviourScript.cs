using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform hedef;
    public Transform hedef2;
    /* Start()

    {
        Debug.Log(transform.position);
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(3f, 4f, 5f) * Time.deltaTime);*/
    void Update()
    {
        hedef.transform.LookAt(hedef2);
    }
}
