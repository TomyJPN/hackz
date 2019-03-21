using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PeelManeger : MonoBehaviour
{
    private float peelTime = 10, timeCount, peelLimit;
    private int peelCount;
    [SerializeField]
    PeelVegetable peelVeg;
    [SerializeField]
    private PeelVegetable[] vegetables;
    private GameObject[] vegetablesObj;

    [SerializeField]
    private Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        peelCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Peel();
        PeelView();
    }

    void Peel()
    {
        if (peelVeg.Peeling)
        {
            timeCount += Time.deltaTime;
            if (timeCount >= peelTime)
            {
                peelCount++;
                timeCount = 0;
                if (peelCount >= peelLimit)
                {
                    //おわた
                    Debug.Log("");
                }
            }
        }
    }

    void PeelView()
    {
        slider.value = timeCount / peelTime;
    }
}
