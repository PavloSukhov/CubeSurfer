using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upswing : MonoBehaviour
{
    bool upswing;
    int index;
    public Selection selection;
    // Start is called before the first frame update
    void Start()
    {
        upswing = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (upswing == true)
        {
            if(transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "CubeBad")
        {
            selection.Fall();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
    public bool Getupswing()
    {
        return upswing;
    }
    public void TopUpswing()
    {
        upswing = true;
    }
    public void indexset(int index)
    {
        this.index = index;
    }
}
