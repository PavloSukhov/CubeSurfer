using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour
{
    GameObject Player;
    int height;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("PlayerStand");
    }

    // Update is called once per frame
    void Update()
    {
        Player.transform.position = new Vector3(transform.position.x, height + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -height, 0);
    }

    public void Fall()
    {
        height--;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CubeGood" && other.gameObject.GetComponent<Upswing>().Getupswing()==false)
        {
            height += 1;
            other.gameObject.GetComponent<Upswing>().TopUpswing();
            other.gameObject.GetComponent<Upswing>().indexset(height);
            other.gameObject.transform.parent = Player.transform;
        }
    }
}
