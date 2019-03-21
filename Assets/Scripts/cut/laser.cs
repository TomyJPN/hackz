using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
  private Vector3 screenPos, objScreenPos, mousePos;
  [SerializeField]
  private Transform laserTransform;
  // Start is called before the first frame update
  void Start() {

  }

  // Update is called once per frame
  void Update() {

  }

  private void OnMouseDrag() {
    objScreenPos = Camera.main.WorldToScreenPoint(laserTransform.position);
    mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, objScreenPos.z);
    laserTransform.position = Camera.main.ScreenToWorldPoint(mousePos);
  }
}
