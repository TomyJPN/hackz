using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peeler : MonoBehaviour
{
    private Vector3 screenPos, objScreenPos, mousePos , knifeTmpPos;
    [SerializeField]
    private Transform knifeTransform;
  private Rigidbody knifeRg;


    // Start is called before the first frame update
    void Start()
    {
    knifeRg = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDrag()
    {
        objScreenPos = Camera.main.WorldToScreenPoint(knifeTransform.position);
        mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, objScreenPos.z);
        knifeTransform.position = Camera.main.ScreenToWorldPoint(mousePos);
    knifeRg.velocity = new Vector3(0, 0, 0);
    
    }
  private void OnMouseUp() {
    this.gameObject.transform.localPosition = new Vector3(0, 0, 0);
    knifeTransform.position = knifeTmpPos;
  }
  private void OnMouseDown() {
    knifeTmpPos = knifeTransform.position;
  }
}
