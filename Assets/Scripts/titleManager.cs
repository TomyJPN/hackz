using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titleManager : MonoBehaviour
{
  public GameObject view1;
  public GameObject view2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  public void startGame() {
    view1.SetActive(false);
    view2.SetActive(true);
  }
  public void selectMenu() {
    SceneManager.LoadScene("UFO");
  }
}
