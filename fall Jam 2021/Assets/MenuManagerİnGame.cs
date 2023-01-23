using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerİnGame : MonoBehaviour
{
    public GameObject İnGameScreen, PauseScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PauseButton()
    {
       Time.timeScale = 0;
       İnGameScreen.SetActive(false);
       PauseScreen.SetActive(true);
    } 
    public void PlayButton() 
    { 
       Time.timeScale = 1;
       İnGameScreen.SetActive(true);
       PauseScreen.SetActive(false);
    } 
    
    public void RestartButton(){
        Time.timeScale=1;
        SceneManager.LoadScene(0);
    }
    public void MainMenuButton(){
        Time.timeScale=1;
        SceneManager.LoadScene(1);
    }


}
