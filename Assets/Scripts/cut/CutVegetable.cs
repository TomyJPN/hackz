using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutVegetable : MonoBehaviour
{
    int cutCount, cutLimit = 2;
    [SerializeField]
    private GameObject vegetable, cutVegetable;
    [SerializeField]
    private CutManeger cutManeger;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Laser")
        {
            cutCount++;
            if (cutLimit <= cutCount)
            {
                Instantiate(cutVegetable, vegetable.transform.position, Quaternion.identity);
                cutManeger.CutVegetableCount++;
                Destroy(vegetable);
            }
        }
    }
}
