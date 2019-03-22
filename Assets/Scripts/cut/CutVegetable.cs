using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutVegetable : MonoBehaviour {
  int cutCount, cutLimit = 2;
  [SerializeField]
  private GameObject vegetable, cutVegetable;
  [SerializeField]
  private CutManeger cutManeger;
  // Start is called before the first frame update
  void Start() {

  }

  // Update is called once per frame
  void Update() {

  }

  private void OnTriggerExit(Collider other) {
    if (other.tag == "Laser") {
      cutCount++;
      if (cutLimit <= cutCount) {

        Quaternion rote = Quaternion.Euler(new Vector3(0.0f, 0.0f, 90.0f));

        Instantiate(cutVegetable, vegetable.transform.position, rote);
        cutManeger.CutVegetableCount++;
        cutManeger.sceneChange();
        Destroy(vegetable);
        Debug.Log("チェンジ");
      }
    }
  }


}
