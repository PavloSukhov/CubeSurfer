using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject NextLevelButton;
    public GameObject LevelPassed;
    // Start is called before the first frame update
    void Start()
    {
        LevelPassed.SetActive(false);
        NextLevelButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" || other.tag == "CubeGood")
        {
            Time.timeScale = 0.2f;
            NextLevelButton.SetActive(true);
            LevelPassed.SetActive(true);
        }
    }
}
