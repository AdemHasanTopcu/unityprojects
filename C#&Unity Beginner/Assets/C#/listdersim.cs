using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listdersim : MonoBehaviour
{
    // Start is called before the first frame update
    string mulktipi;
    string bloktipi;
    int benimkatsayim = 2;
    void Start()
    {
        /* List<int> yaslar = new List<int>();
         yaslar.Add(50);
         yaslar.Add(40);
         yaslar.Add(18);
         // Debug.Log(yaslar.Count);*/
        /* foreach (var item in yaslar)
         {
             Debug.Log(item);
         }*/
        /*yaslar.Insert(3,90);
        for (int i = 0; i <yaslar.Count; i++)
        {
            Debug.Log(yaslar[i]);
        }
        yaslar.Remove(90);
        for (int i = 0; i < yaslar.Count; i++)
        {
            Debug.Log(yaslar[i]);
        }
        if (yaslar.Contains(50))
            Debug.Log("yes");
        else
            Debug.Log("no");*/

        /*  string taskagitmakas(string bir, string iki)
              => (bir, iki) switch
              { 
                  ("tas", "kagit") => "kagit kazandi",
                  (_,_)=>"boþ"

              };
          Debug.Log(taskagitmakas("tas", "kagit"));  
        int aidathesapla*/


        int aidathesapla(listdersim classimbenim, int aidatcarpankatsayisi)
            => classimbenim switch
            {
                { mulktipi: "Daire", bloktipi: "A" } => aidatcarpankatsayisi * 3,
                { mulktipi: "Villa", bloktipi: "B" } => aidatcarpankatsayisi * 2,
                { mulktipi: "Rezidans", bloktipi: "C" } => aidatcarpankatsayisi * 1,
                _ => 0

            };
        mulktipi = "Daire";
        bloktipi = "A";
        Debug.Log(aidathesapla(this, benimkatsayim));

    }


}
