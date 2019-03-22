using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cook : MonoBehaviour {
  public GameObject fade;
  public GameObject curryImg;

  Image image;
  float alfa;
  float speed = 0.01f;
  float red, green, blue;
  // Start is called before the first frame update
  void Start() {
    image = fade.GetComponent<Image>();
    red = image.color.r;
    green = image.color.g;
    blue = image.color.b;
    Invoke("viewImg", 3f);
  }

  // Update is called once per frame
  void Update() {
    image.color = new Color(red, green, blue, alfa);
    alfa += speed;
  }
  void viewImg() {
    curryImg.SetActive(true);
    Invoke("backTitle", 3f);
  }
  void backTitle() {
    SceneManager.LoadScene("Title");
  }
}
