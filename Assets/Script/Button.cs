using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour
{
    public GameObject RestartButton;
    public GameObject NextLevelButton;
    public GameObject StartButton;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPlayHandler()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void StartGame()
    {
        StartButton.SetActive(false);
        Time.timeScale = 0.7f;
    }
}
