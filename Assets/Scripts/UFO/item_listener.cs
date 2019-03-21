using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item_listener : MonoBehaviour {
  public GameObject message;
  public GameObject pepperImg;
  public GameObject tomatoImg;
  public GameObject nasuImg;
  public Text text;

  // Start is called before the first frame update
  void Start() {

  }

  // Update is called once per frame
  void Update() {

  }

  void OnTriggerEnter(Collider other) {
    if (other.tag == "Item") {
      message.SetActive(true);
      text.text =other.name+ "をゲット！";
      if (other.name == "ピーマン") pepperImg.SetActive(true);
      else if (other.name == "ナス") nasuImg.SetActive(true);
      else if (other.name == "トマト") tomatoImg.SetActive(true);
    }

  }
}
