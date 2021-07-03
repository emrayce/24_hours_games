using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public Image mainMenu;
    public Image lvlSelection;
    private string scene = "Lvl_";

    public void Start()
    {
        lvlSelection.gameObject.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void ToLvlSelection()
    {
        mainMenu.gameObject.SetActive(false);
        lvlSelection.gameObject.SetActive(true);
    }

    public void ToMainMenu()
    {
        lvlSelection.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(true);
    }

    public void SelectLvl(int lvl)
    {
        string level = scene + lvl.ToString();
        SceneManager.LoadScene(level);
    }
}
