using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plus : MonoBehaviour
{
    public Click gm;
    


    public void Plus0() 
    {

        if (gm.Gold >= 100)
        {
            gm.Gold -= 100;
            gm.goldPerClick += 2;
        }

        
    }
   


}
