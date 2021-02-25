using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class h100 : MonoBehaviour
{
    public Click gm;

    public void Plus0()
    {
        if (gm.Gold >= 800)
        {
            gm.Gold -= 800;
            gm.goldPerClick *= 2;
        }
    }

}
