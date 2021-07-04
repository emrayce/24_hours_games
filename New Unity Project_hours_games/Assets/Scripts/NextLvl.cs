using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLvl : MonoBehaviour
{
    public int currentLvl;
    private string scene = "Lvl_";

    public void PasstoNextLvl()
    {
        currentLvl++;
        SceneManager.LoadScene(scene + currentLvl);
    }
}
