using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public Image mainMenu;
    public Image lvlSelection;
    public Image gameSelection;

    private Image currentMenu;

    private string scene = "Lvl_";

    public void Start()
    {
        gameSelection.gameObject.SetActive(false);
        lvlSelection.gameObject.SetActive(false);

        currentMenu = mainMenu;
    }

    public void Quit()
    {
        Application.Quit();
    }
        
    public void ToLvlSelection()
    {
        currentMenu.gameObject.SetActive(false);
        currentMenu = lvlSelection;
        currentMenu.gameObject.SetActive(true);
    }

    public void ToGameSelection()
    {
        currentMenu.gameObject.SetActive(false);
        currentMenu = gameSelection;
        currentMenu.gameObject.SetActive(true);
    }

    public void ToMainMenu()
    {
        currentMenu.gameObject.SetActive(false);
        currentMenu = mainMenu;
        currentMenu.gameObject.SetActive(true);
    }

    public void SelectLvl(int lvl)
    {
        string level = scene + lvl.ToString();
        SceneManager.LoadScene(level);
    }
}
