using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Death : MonoBehaviour
{
    public GameObject RestartButton;
    public GameObject LevelFailed;
    // Start is called before the first frame update
    void Start()
    {
        LevelFailed.SetActive(false);
        RestartButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            Time.timeScale = 0.1f;
            RestartButton.SetActive(true);
            LevelFailed.SetActive(true);
        }
    }
}
