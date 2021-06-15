using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{   
    [SerializeField] private Transform playerstand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player"|| other.tag == "CubeGood")
        {
            playerstand.transform.Rotate(0.0f, 90.0f/2, 0.0f);
        }
    }
   
}

