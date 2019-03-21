using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeelVegetable : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private string animationName;
    [SerializeField]
    private ParticleSystem particle;
    public bool Peeling { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        Peeling = false;
        particle.Stop();
        Spin();
    }

    // Update is called once per frame
    void Update()
    {

    }

  private void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.tag == "Knife") {
      Peeling = true;
      particle.Play();
    }
  }

  private void OnCollisionExit(Collision collision) {
    if (collision.gameObject.tag == "Knife") {
      Peeling = false;
      particle.Stop();
    }
  }

  private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Knife")
        {
            Peeling = true;
            particle.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Knife")
        {
            Peeling = false;
            particle.Stop();
        }
    }

    void Spin()
    {
        animator.SetBool(animationName, true);
    }
}
