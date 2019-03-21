using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutVegetable : MonoBehaviour
{
    int cutCount, cutLimit = 3;
    [SerializeField]
    private GameObject vegetable, cutVegetable;
    // Start is called before the first frame update
    void Start()
    {
        cutCount = 0;
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
                Destroy(vegetable);
            }
        }
    }
}
