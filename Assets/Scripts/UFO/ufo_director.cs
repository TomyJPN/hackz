using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufo_director : MonoBehaviour
{
  public GameObject howtoUI;
  public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  public void closeMessage() {
    howtoUI.SetActive(false);
    button.SetActive(true);
  }
}
