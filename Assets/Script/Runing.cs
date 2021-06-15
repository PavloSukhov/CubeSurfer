using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runing : MonoBehaviour
{
     private Animator Flip;

    // Start is called before the first frame update
    void Start()
    {
        Flip = GetComponent<Animator>();
        //GetComponent<Animation>().Play("Run");
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0.1f)
        {
            Flip.Play("Flip");
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CubeBad")
        {
            Flip.Play("Flip");

        }
    }
}
