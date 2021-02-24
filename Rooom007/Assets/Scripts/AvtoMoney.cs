using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvtoMoney : MonoBehaviour
{
    public Click gm;
    public void Avto() 
    {
        
        if (gm.Gold >= 5)
        {
           
            gm.Gold -= 5;
            StartCoroutine(IdleFarm0());
        }


    }
    IEnumerator IdleFarm0()
    {
        while (true)
        {
            gm.Gold += 1;
            yield return new WaitForSeconds(1);
           
        }


    }

}
