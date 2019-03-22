using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutManeger : MonoBehaviour
{
    public int CutVegetableCount { get; set; }
    private int cutLimit = 2;

  public GameObject howtoUI;
  public GameObject messageUI;
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
  public void sceneChange() {
    Invoke("UI", 1f);
    Invoke("a", 4.5f);
  }
  void UI() {
    messageUI.SetActive(true);
  }
  void a() {
    Debug.Log("sceneチェンジ");
    SceneManager.LoadScene("cook");
  }

  public void closeUI() {
    howtoUI.SetActive(false);
  }
}
