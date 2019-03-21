using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peeler : MonoBehaviour
{
    private Vector3 screenPos, objScreenPos, mousePos;
    [SerializeField]
    private Transform knifeTransform;
    // Start is called before the first frame update
    void Start()
    {

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
    }
}
