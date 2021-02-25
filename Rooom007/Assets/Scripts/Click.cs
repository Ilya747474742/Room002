using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{   
    public UnityEngine.UI.Text GoldDisplay;
    public float goldPerClick = 1;
    public float Gold = 0;

     void Start()
    {
        Gold = 0;
        StartCoroutine(IdleFarm0());

    }
    IEnumerator IdleFarm0()
    {
        while (true)
        {
            Gold += 1;
            yield return new WaitForSeconds(1);

        }
    }


    void Update()
    {
        GoldDisplay.text = "Gold: " + Gold + "$";
        
    }
}
