using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int coint;
    public Text TextCoint;
    // Start is called before the first frame update
    void Start()
    {
        coint = PlayerPrefs.GetInt("Money");
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("Money", coint);
        TextCoint.text = "" + coint;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" || other.tag == "CubeGood")
        {
            coint ++;
            Destroy(gameObject);
        }
    }
}
