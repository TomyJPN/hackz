using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutManeger : MonoBehaviour
{
    public int CutVegetableCount { get; set; }
    private int cutLimit = 2;
    // Start is called before the first frame update
    void Start()
    {
        CutVegetableCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (CutVegetableCount >= cutLimit)
        {
            Debug.Log("owari");
        }
    }
}
