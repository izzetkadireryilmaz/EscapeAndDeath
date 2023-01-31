using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerMenuScane : MonoBehaviour
{
    public GameObject OyunKayýt, PauseScreen;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(8);
    }

    public void ObjectsScane()
    {
        SceneManager.LoadScene(2);
    }

    public void MenuScane()
    {
        SceneManager.LoadScene(0);
    }

    public void PauseScane()
    {
        Time.timeScale = 0;
        OyunKayýt.SetActive(false);
        PauseScreen.SetActive(true);
        
    }

    public void ResumeScane()
    {
        Time.timeScale = 1;
        OyunKayýt.SetActive(true);
        PauseScreen.SetActive(false);
    }
    public void MenuButtonIng()
    {
        SceneManager.LoadScene(5);
    }
    public void ObjectsButtonIng()
    {
        SceneManager.LoadScene(4);
    }
    public void GameIng()
    {
        SceneManager.LoadScene(38);
        Time.timeScale = 1;
    }

    public void NormalGame()
    {
        SceneManager.LoadScene(69);
        Time.timeScale = 1;
    }
    public void NormalGameIng()
    {
        SceneManager.LoadScene(70);
        Time.timeScale = 1;
    }




    public void QuitButton()
    {
        Application.Quit();
    }

    public void Level1Button()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void Level2Button()
    {
        SceneManager.LoadScene(9);
        Time.timeScale = 1;
    }
    public void Level3Button()
    {
        SceneManager.LoadScene(10);
        Time.timeScale = 1;
    }
    public void Level4Button()
    {
        SceneManager.LoadScene(11);
        Time.timeScale = 1;
    }
    public void Level5Button()
    {
        SceneManager.LoadScene(12);
        Time.timeScale = 1;
    }
    public void Level6Button()
    {
        SceneManager.LoadScene(13);
        Time.timeScale = 1;
    }
    public void Level7Button()
    {
        SceneManager.LoadScene(14);
        Time.timeScale = 1;
    }
    public void Level8Button()
    {
        SceneManager.LoadScene(15);
        Time.timeScale = 1;
    }
    public void Level9Button()
    {
        SceneManager.LoadScene(16);
        Time.timeScale = 1;
    }
    public void Level10Button()
    {
        SceneManager.LoadScene(17);
        Time.timeScale = 1;
    }
    public void Level11Button()
    {
        SceneManager.LoadScene(18);
        Time.timeScale = 1;
    }
    public void Level12Button()
    {
        SceneManager.LoadScene(19);
        Time.timeScale = 1;
    }
    public void Level13Button()
    {
        SceneManager.LoadScene(20);
        Time.timeScale = 1;
    }
    public void Level14Button()
    {
        SceneManager.LoadScene(21);
        Time.timeScale = 1;
    }
    public void Level15Button()
    {
        SceneManager.LoadScene(22);
        Time.timeScale = 1;
    }
    public void Level1Button_Ing()
    {
        SceneManager.LoadScene(39);
        Time.timeScale = 1;
    }
    public void Level2Button_Ing()
    {
        SceneManager.LoadScene(40);
        Time.timeScale = 1;
    }
    public void Level3Button_Ing()
    {
        SceneManager.LoadScene(41);
        Time.timeScale = 1;
    }
    public void Level4Button_Ing()
    {
        SceneManager.LoadScene(42);
        Time.timeScale = 1;
    }
    public void Level5Button_Ing()
    {
        SceneManager.LoadScene(43);
        Time.timeScale = 1;
    }
    public void Level6Button_Ing()
    {
        SceneManager.LoadScene(44);
        Time.timeScale = 1;
    }
    public void Level7Button_Ing()
    {
        SceneManager.LoadScene(45);
        Time.timeScale = 1;
    }
    public void Level8Button_Ing()
    {
        SceneManager.LoadScene(46);
        Time.timeScale = 1;
    }
    public void Level9Button_Ing()
    {
        SceneManager.LoadScene(47);
        Time.timeScale = 1;
    }
    public void Level10Button_Ing()
    {
        SceneManager.LoadScene(48);
        Time.timeScale = 1;
    }
    public void Level11Button_Ing()
    {
        SceneManager.LoadScene(49);
        Time.timeScale = 1;
    }
    public void Level12Button_Ing()
    {
        SceneManager.LoadScene(50);
        Time.timeScale = 1;
    }
    public void Level13Button_Ing()
    {
        SceneManager.LoadScene(51);
        Time.timeScale = 1;
    }
    public void Level14Button_Ing()
    {
        SceneManager.LoadScene(52);
        Time.timeScale = 1;
    }
    public void Level15Button_Ing()
    {
        SceneManager.LoadScene(53);
        Time.timeScale = 1;
    }

}